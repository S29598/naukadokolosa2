using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDB_Kolokwium_template.Models;

[Table(nameof(Project))]
public class Project
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)] 
    public string Name { get; set; } = null!;
    
    [MaxLength(50)]
    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; } 
    
    public DateTime? EndDate { get; set; }
    
    public decimal Budget { get; set; }
}