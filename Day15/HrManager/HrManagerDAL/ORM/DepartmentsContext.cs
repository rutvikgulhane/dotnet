namespace HrManagerDAL.ORM;
using Microsoft.EntityFrameworkCore;
using HrManagerBOL.Entities;


public class DepartmentsContext : DbContext
{
    public DepartmentsContext(DbContextOptions<DepartmentsContext> options):base(options) {}
    public DbSet<Department> Departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"server=localhost;port=3306;user=root; password=password;database=emp_info";
        optionsBuilder.UseMySQL(conString);
    }

    // schema
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Department_name).IsRequired();
        });
        modelBuilder.Entity<Department>().ToTable("departments");
        
        
         modelBuilder.Entity<Employee>(
            entity => {
                entity.HasKey(en => en.Id);
                entity.Property(en => en.First_name);
                entity.Property(en => en.Last_name);
                entity.Property(en => en.Email);
                entity.Property(en => en.Gender);
                entity.Property(en => en.Password);
                entity.Property(en => en.DeptId);
                entity.Property(en => en.JobId);
            }
        );

        modelBuilder.Entity<Employee>().ToTable("employees");
    }
}