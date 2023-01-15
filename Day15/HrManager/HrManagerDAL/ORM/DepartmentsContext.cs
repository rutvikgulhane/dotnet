namespace HrManagerDAL.ORM;
using Microsoft.EntityFrameworkCore;
using HrManagerBOL.Entities;


public class DepartmentsContext : DbContext
{
    
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
    }
}