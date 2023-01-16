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


  public async Task InsertDepartment(Department department)
  {
    
        await _departmentsContext.Departments.AddAsync(department);
        await _departmentsContext.SaveChangesAsync();
    
  }

  public async Task<Department> UpdateDepartment(Department department)
  {
    
        // we find asynchronously and await for the result
        var thisDepartment = await _departmentsContext.Departments.FirstOrDefaultAsync(d=> d.Id == department.Id);
        thisDepartment.Department_name = department.Department_name;
        await _departmentsContext.SaveChangesAsync();
        return thisDepartment;
  }

  public async Task<bool> DeleteDepartment(int id)
  {
    
        var department = (_departmentsContext.Departments.FirstOrDefault(d => d.Id  == id));
        if (department == null)
        {
            return false;
        }
        _departmentsContext.Remove(department);
        await _departmentsContext.SaveChangesAsync();
        return true;
    }
  



    // public List<Employee> GetEmployees(){
    //     using (EmployeesContext employeesContext = new EmployeesContext())
    //     {
         
    //         return employeesContext.Employees.ToList<Employee>();
    //     }
    // }
}
