using DTOs;

namespace Services.Interfaces
{
    public interface ICommunitiesForOrganizationService
    {
        Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationAsync();
        Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationByOrganizationIdAsync(int id);
    }
}
