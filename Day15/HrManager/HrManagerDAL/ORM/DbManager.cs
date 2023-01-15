namespace HrManagerDAL.ORM;
using HrManagerBOL.Entities;
using Microsoft.EntityFrameworkCore;
public class DbManager {

    public static List<Department> GetDepartments(){
        using (DepartmentsContext departmentsContext = new DepartmentsContext())
        {
         
            return departmentsContext.Departments.ToList<Department>();
        }
    }
    
    public static Department GetDepartment(int id){
        using (DepartmentsContext departmentsContext = new DepartmentsContext())
        {
         
            return departmentsContext.Departments.Find(id);
        }
    }

    public static List<Employee> GetEmployees(){
        using (EmployeesContext employeesContext = new EmployeesContext())
        {
         
            return employeesContext.Employees.ToList<Employee>();
        }
    }




}
