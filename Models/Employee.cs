using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using APDB_Kolokwium_template.Models;

namespace APDB_Kolokwium_template.DTOs;

[Table(nameof(Employee))]
public class Employee {
    [Key]
    public int Id { get; set; }

    [MaxLength(50)] 
    public string FirstName { get; set; } = null!;

    [MaxLength(50)] 
    public string LastName { get; set; } = null!;
    
    [MaxLength(50), EmailAddress]
    public string Email { get; set; } = null!;
    
    [MaxLength(50)]
    public string Position { get; set; } = null!;
    
    public decimal Salary { get; set; } 
    
    public virtual ICollection<Assignment> Assignments { get; set; } = null!;
}