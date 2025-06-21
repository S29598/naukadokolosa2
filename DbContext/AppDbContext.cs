using APDB_Kolokwium_template.DTOs;
using APDB_Kolokwium_template.Models;
using Microsoft.EntityFrameworkCore;

namespace APDB_Kolokwium_template.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; } 
    
    public AppDbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var employees = new List<Employee>
        {
            new()
            {
                Id = 1,
                FirstName = "Anna",
                LastName = "Kowalska",
                Email = "anna.kowalska@example.eu",
                Position = "Senior Developer",
                Salary = 10000
            },
            new()
            {
                Id = 2,
                FirstName = "Tomasz",
                LastName = "Kot",
                Email = "tomasz.kot@example.eu",
                Position = "Service Desk",
                Salary = 5000
            }
        };

        var projects = new List<Project>
        {
            new()
            {
                Id = 1,
                Name = "System CRM",
                Description = "Opis",
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 12, 31),
                Budget = 150000,
            },
            new()
            {
                Id = 2,
                Name = "System ABC",
                Description = "Opis 2",
                StartDate = new DateTime(2015, 1, 1),
                EndDate = new DateTime(2015, 12, 31),
                Budget = 250000,
            },
        };

        var assignments = new List<Assignment>
        {
            new()
            {
                Id = 1,
                EmployeeId = 1,
                ProjectId = 1,
                AssignmentDate = new DateTime(2024, 10, 1, 9, 0, 0),
                HoursPerWeek = 40,
                Role = "Lead Developer"
            }
        };
        
        modelBuilder.Entity<Employee>().HasData(employees);
        modelBuilder.Entity<Project>().HasData(projects);
        modelBuilder.Entity<Assignment>().HasData(assignments);
    }
    
}