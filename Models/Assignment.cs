using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APDB_Kolokwium_template.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APDB_Kolokwium_template.Models;

[Table(nameof(Assignment))]
public class Assignment
{
    [Key]
    public int Id { get; set; }
    
    public int EmployeeId { get; set; }
    
    public int ProjectId { get; set; }
    
    public DateTime AssignmentDate { get; set; }
    
    public int HoursPerWeek { get; set; }
    
    [MaxLength(50)]
    public string Role { get; set; } = null!;
    
    [ForeignKey(nameof(ProjectId))]
    public virtual Project Project { get; set; } = null!;
    
    [ForeignKey(nameof(EmployeeId))]
    public virtual Employee Employee { get; set; } = null!;
    
    public virtual ICollection<Assignment> Assignments { get; set; } = null!;
}