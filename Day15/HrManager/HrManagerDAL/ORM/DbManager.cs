namespace HrManagerDAL.ORM;
using HrManagerBOL;
using Microsoft.EntityFrameworkCore;

public class DbManager {

    public static List<Department> GetDepartments(){
        using (var dpContext = new CollectionContext())
        {
            var departments = dpContext.ToListAsync();
        }
    }
}
