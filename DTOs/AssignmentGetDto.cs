namespace APDB_Kolokwium_template.DTOs;

public class AssignmentGetDto
{
    public EmployeeGetDto employee { get; set; } = null!;
    public ProjectGetDto project { get; set; } = null!;
    
    public string role { get; set; } = null!;
    public int hoursPerWeek { get; set; }
    public DateTime assignmentDate { get; set; }
}