using APDB_Kolokwium_template.DTOs;

namespace APDB_Kolokwium_template.Services;

public interface IDbService
{
    public Task<ICollection<AssignmentGetDto>> GetAssignments();
}