using HrManagerBOL.Entities;
using HrManagerDAL.ORM;
using System.Collections.Generic;


List<Department> departments = DbManager.GetDepartments();
departments.ForEach(d => System.Console.WriteLine(d));
System.Console.WriteLine();
List<Employee> employees = DbManager.GetEmployees();
employees.ForEach(d => System.Console.WriteLine(d));