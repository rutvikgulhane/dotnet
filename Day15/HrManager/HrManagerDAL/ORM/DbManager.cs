namespace HrManagerDAL.ORM;
using HrManagerBOL.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
public class DbManager : IDbManager {

    public List<Department> GetDepartments(){
        using (DepartmentsContext departmentsContext = new DepartmentsContext())
        {
         
            var departments = from d in departmentsContext.Departments select d;
            return departments.ToList<Department>();
        }
    }
    
    public Department GetDepartment(int id){
        using (DepartmentsContext departmentsContext = new DepartmentsContext())
        {
         
            return departmentsContext.Departments.Find(id);
        }
    }


  public void InsertDepartment(Department department)
  {
    using (DepartmentsContext dContext = new DepartmentsContext())
    {
        dContext.Departments.Add(department);
        dContext.SaveChanges();
    }
  }

  public void UpdateDepartment(Department department)
  {
    using (DepartmentsContext dContext = new DepartmentsContext())
    {
        var thisDepartment = dContext.Departments.Find(department.Id);
        thisDepartment.Department_name = department.Department_name;
        dContext.SaveChanges();
    }
  }

  public void DeleteDepartment(int id)
  {
    using (DepartmentsContext dContext = new DepartmentsContext())
    {
        dContext.Departments.Remove(dContext.Departments.Find(id));
        dContext.SaveChanges();
    }
  }



    public List<Employee> GetEmployees(){
        using (EmployeesContext employeesContext = new EmployeesContext())
        {
         
            return employeesContext.Employees.ToList<Employee>();
        }
    }
}
