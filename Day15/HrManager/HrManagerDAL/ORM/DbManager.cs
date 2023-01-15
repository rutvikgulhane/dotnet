namespace HrManagerDAL.ORM;
using HrManagerBOL.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
public class DbManager : IDbManager {

    private readonly DepartmentsContext _departmentsContext;

    public DbManager(DepartmentsContext departmentsContext) {
        _departmentsContext = departmentsContext;
    }

    public async Task<List<Department>> GetDepartments(){
       
            return await _departmentsContext.Departments.ToListAsync();
    }
    
    public async Task<Department> GetDepartment(int id){
       
         
            return await _departmentsContext.Departments.FirstOrDefaultAsync(d=>d.Id==id);
    }

/* 
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
    } */
}
