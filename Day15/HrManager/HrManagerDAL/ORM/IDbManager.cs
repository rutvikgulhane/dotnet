namespace HrManagerDAL.ORM;
using HrManagerBOL.Entities;
public interface IDbManager {
    // CRUD for Departments
    void InsertDepartment(Department department);
    List<Department> GetDepartments();
    Department GetDepartment(int id);

    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
    
    // CRUD for Employees
    void InsertEmployee(Employee employee);
    List<Employee> GetEmployees();
    Employee GetEmployee(int id);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int id);
    
    
    // CRUD for Jobs
    void InsertJob(Job job);
    List<Job> GetJobs();
    Job GetJob(int id);
    void UpdateJob(Job job);
    void DeleteJob(int id);

}