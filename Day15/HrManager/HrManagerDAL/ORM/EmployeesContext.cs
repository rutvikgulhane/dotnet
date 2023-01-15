namespace HrManagerDAL.ORM;

using Microsoft.EntityFrameworkCore;
using HrManagerBOL.Entities;

public class EmployeesContext : DbContext {

    public DbSet<Employee>? Employees {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) {
        string conString = @"server=localhost; port=3306; user=root;password=password; database=emp_info";
        dbContextOptionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
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