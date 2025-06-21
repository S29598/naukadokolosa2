namespace APDB_Kolokwium_template.DTOs;

public class ProjectGetDto
{
    public int id { get; set; }
    public string name { get; set; } = null!;
    public decimal budget { get; set; }
}