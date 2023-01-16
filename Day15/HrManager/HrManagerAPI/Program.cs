using HrManagerBOL.Entities;
using HrManagerDAL.ORM;



/* Run the App by going into HrManagerAPI, open terminal => 
                                                            dotnet run
                                                            open browser -> paste the link -> type -> http://localhost:port/swagger  */





var builder = WebApplication.CreateBuilder(args);

// Setup database connection


// Add services to the container.

// DI - Register DbManager 
builder.Services.AddTransient<IDbManager, DbManager>();

// add cors
builder.Services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<DepartmentsContext>();

builder.Services.AddHealthChecks();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

app.UseCors(builder => {
    builder.AllowAnyHeader()
           .AllowAnyMethod()
           .AllowAnyOrigin();
});

// app.MapControllers();

app.MapGet("/", ()=>"Hello World!");

/* The 'MapPost' to create the HTTP Post endpoint. This method takes 2 input parameters where the 1st parameter is 'URL' and 2nd parameter is the delegate function that contains all execution logic of our Minimal API.
   The Delegate handler we created as an asynchronous method. This Delegate handler is a custom method and here passes parameters like 1st parameter like payload of type 'Gadgets' and 2nd parameter is injected 'DatabaseContext'.
   Logic to save data to the database.
) Returning 'Ok' API response. */
app.MapPost("/api/departments/create", async (Department department, IDbManager dbManager) => {
    await dbManager.InsertDepartment(department);
    return Results.Ok();
});


/*  The 'MapGet' method represents HTTP get endpoint. The 'MapGet' method has 2 parameters like 1st parameter is 'URL' and 2nd parameter is 'Delegate'.
The 'Delegate' is implemented as an asynchronous method. Injected 'DatabaseContext' as an input parameter.
 Logic to fetching the collection of records from the database. */    
app.MapGet("/api/departments", async (IDbManager dbManager) => {
    var departments = await dbManager.GetDepartments();
    return Results.Ok(departments);
});



app.MapGet("/api/departments/{id}", async (int id, IDbManager dbManager) => {
    
    var department = await dbManager.GetDepartment(id);
    if (department == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(department);
});


/*  The 'MapPut' method represents the HTTP Put endpoint. The 'MapPut' method has 2 parameters like 1st parameter is 'URL' and 2nd parameter is the 'Delegate'. Here implemented Delegate as an asynchronous method that has 2 input parameters like 1st parameter payload to be updated and 2nd parameter injected the 'DatabaseContext'.
    Fetching the existing data from the database.
    Checking record trying to update is valid or not.
    Updating and saving the record into the table. */
app.MapPut("/api/departments/update", async (Department department, IDbManager dbManager) => {
    
    var thisDepartment = await dbManager.UpdateDepartment(department);
    if (thisDepartment== null)
    {
        return Results.NotFound();
    }
    // we save those canges asynchronously and await to avoid the lag and sync issues
    return Results.Ok();
});


/*  The 'MapDelete' method represents the HTTP Delete endpoint. The 'MapDelete' method has 2 input parameters like 1st parameter is 'URL' and 2nd parameter is Delegate. Inside URL we can pass dynamic values with the '{}' expression, these values can be read into the Delegate handler method as input parameters.
    Fetching the record that needs to be deleted.
    Deleting the record from the database. */
app.MapDelete("/api/departments/delete{id}", async (int id, IDbManager dbManager) => {

    var thisDepartment = await dbManager.GetDepartment(id);
    if (thisDepartment == null)
    {
        return Results.NoContent();
    }
    await dbManager.DeleteDepartment(thisDepartment.Id);
    return Results.Ok();
});

app.Run();
