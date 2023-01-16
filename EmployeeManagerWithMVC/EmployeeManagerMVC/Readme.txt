## WARNING INCOMPLETE FILE ##

CRUD Operations on Employee Table using ASP .NET MVC
-------------------------------------------------------------------------------------------------

steps to follow =>

IN MYSQL,
alter user 'root'@'localhost' identified with mysql_native_password by 'password'; 
#don't paste this line -> (password is the new password of your machine's mysql)
flush privileges;

paste the sql file present in DBFiles->EmployeeManagerMVC.sql

-------------------------------------------------------------------------------------------------

// open/create a folder and open it with cmd and copypaste:
mkdir EmployeeManagerMVC
cd EmployeeManagerMVC
dotnet new sln
dotnet new mvc -o EmployeeManagerMVC
dotnet sln add EmployeeManagerMVC/EmployeeManagerMVC.csproj
cd myapp
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.17
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.17
dotnet add package MySql.EntityFrameworkCore --version 5.0.17+MySQL8.0.31  
dotnet tool install --global dotnet-ef

dotnet ef dbcontext scaffold "server=localhost;user id=root;password=password; database=EmployeeManager" MySql.EntityFrameworkCore -o Models

-------------------------------------------------------------------------------------------------

//open program.cs in <name> 
//1st line write : 
-------------------------------------------------------------------------------------------------
	using <name>.Models;
-------------------------------------------------------------------------------------------------
6th line write:
-------------------------------------------------------------------------------------------------
// DBContext's name is taken fromt the database name
  builder.Services.AddDbContext<EmployeeManagerContext>();
-------------------------------------------------------------------------------------------------

// Make a new EmployeeController for CRUD on Employee table


-------------------------------------------------------------------------------------------------
	dotnet run
-------------------------------------------------------------------------------------------------
