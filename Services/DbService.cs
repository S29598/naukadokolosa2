using APDB_Kolokwium_template.DAL;
using APDB_Kolokwium_template.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APDB_Kolokwium_template.Services;

public class DbService(AppDbContext data) : IDbService
{
    public async Task<ICollection<AssignmentGetDto>> GetAssignments()
    {
        return await data.Assignments.Select(e => new AssignmentGetDto
        {
            employee = new EmployeeGetDto()
            {
                firstName = e.Employee.FirstName,
                lastName = e.Employee.LastName,
                position = e.Employee.Position
            },
            
            project = new ProjectGetDto(){
                id = e.Project.Id,
                name = e.Project.Name,
                budget = e.Project.Budget
            },
            
            role = e.Role,
            hoursPerWeek = e.HoursPerWeek,
            assignmentDate = e.AssignmentDate
            
        }).ToListAsync();
    }
};