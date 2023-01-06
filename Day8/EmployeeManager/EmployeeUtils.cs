namespace HRManager;
using System.Text.Json;
public class EmployeeUtils
{
    public static List<Employee> GetSomeEmployees()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { Id = 23, FirstName = "Ravi", LastName = "Tambade" });
        employees.Add(new Employee() { Id = 24, FirstName = "Sachin", LastName = "Nene" });
        employees.Add(new Employee() { Id = 25, FirstName = "Shivani", LastName = "Pande" });
        employees.Add(new Employee() { Id = 26, FirstName = "Madhu", LastName = "Sharma" });
        return employees;
    }

    public static void WriteIntoFileInJson(List<Employee> employees)
    {
        var employeesSeting = JsonSerializer.Serialize(employees);
        File.WriteAllText(@"/media/runner/DATA/IACSD AKURDI/DOT_NET/DN_Assignments/Day8/EmployeeManager/employee-database.json", employeesSeting);
    }

    public static List<Employee> ReadFromFileInList()
    {
        List<Employee> empList = new List<Employee>();
        var emps = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(@"/media/runner/DATA/IACSD AKURDI/DOT_NET/DN_Assignments/Day8/EmployeeManager/employee-database.json"));
        foreach (var item in emps)
        {
            Employee emp = item as Employee;
            empList.Add(emp);
        }

        empList.ForEach(x => System.Console.WriteLine(x));
        return empList;
    }




}