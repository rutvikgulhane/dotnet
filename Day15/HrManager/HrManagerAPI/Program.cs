using HrManagerBOL.Entities;
using HrManagerDAL.ORM;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

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

builder.Services.AddDbContext<DepartmentsContext>(options => {
    options.UseMySQL(builder.
                     Configuration.
                     GetConnectionString("DefaultConnection"));  
});

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

/* (Line: 1) The 'MapPost' to create the HTTP Post endpoint. This method takes 2 input parameters where the 1st parameter is 'URL' and 2nd parameter is the delegate function that contains all execution logic of our Minimal API.
    The Delegate handler we created as an asynchronous method. This Delegate handler is a custom method and here passes parameters like 1st parameter like payload of type 'Gadgets' and 2nd parameter is injected 'DatabaseContext'.
    (Line: 2-3) Logic to save data to the database.
    (Line: 4) Returning 'Ok' API response. */
/* app.MapPost("/api/departments/create", async (Department department, IDbManager dContext) => {
    dContext.Departments.Add(department);
    await dContext.SaveChangesAsync();
    return Results.Ok();
});
 */

/* (Line: 1) The 'MapGet' method represents HTTP get endpoint. The 'MapGet' method has 2 parameters like 1st parameter is 'URL' and 2nd parameter is 'Delegate'.
The 'Delegate' is implemented as an asynchronous method. Injected 'DatabaseContext' as an input parameter.
(Line: 3-4) Logic to fetching the collection of records from the database. */    
app.MapGet("/api/departments", async (IDbManager dContext) => {
    var departments = await dContext.GetDepartments();
    return Results.Ok(departments);
});



/* app.MapGet("/api/departments/{id}", async (int id, IDbManager dbManaher) => {
    IDbManager dbManager = new DbManager();
    return dbManager.GetDepartment(id);
});
 */

/*  (Line: 1) The 'MapPut' method represents the HTTP Put endpoint. The 'MapPut' method has 2 parameters like 1st parameter is 'URL' and 2nd parameter is the 'Delegate'. Here implemented Delegate as an asynchronous method that has 2 input parameters like 1st parameter payload to be updated and 2nd parameter injected the 'DatabaseContext'.
    (Line: 3) Fetching the existing data from the database.
    (Line: 4-7) Checking record trying to update is valid or not.
    (Line: 8-13) Updating and saving the record into the table. */
/* app.MapPut("/api/departments/update", async (Department updatedDepatment, IDbManager dContext) => {
    
    // we find asynchronously and await for the result
    var thisDepartment = await dContext.Departments.FindAsync(updatedDepatment.Id);
    if (thisDepartment == null)
    {
        return Results.NotFound();
    }
    thisDepartment.Department_name = updatedDepatment.Department_name;
    // we save those canges asynchronously and await to avoid the lag and sync issues
    await dContext.SaveChangesAsync();
    return Results.Ok();
}); */


/*  (Line: 1) The 'MapDelete' method represents the HTTP Delete endpoint. The 'MapDelete' method has 2 input parameters like 1st parameter is 'URL' and 2nd parameter is Delegate. Inside URL we can pass dynamic values with the '{}' expression, these values can be read into the Delegate handler method as input parameters.
    (Line: 3-7) Fetching the record that needs to be deleted.
    (Line: 8-10) Deleting the record from the database. */
/* app.MapDelete("/api/departments/delete{id}", async (int id, IDbManager dContext) => {

    var thisDepartment = await dContext.Departments.FindAsync(id);
    if (thisDepartment == null)
    {
        return Results.NoContent();
    }
    dContext.Departments.Remove(thisDepartment);
    await dContext.SaveChangesAsync();
    return Results.Ok();
}); */





app.Run();
