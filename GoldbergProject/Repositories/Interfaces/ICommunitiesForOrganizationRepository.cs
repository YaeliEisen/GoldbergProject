using GoldbergProject.Models;


namespace Repositories.Interfaces
{
    public interface ICommunitiesForOrganizationRepository
    {
        Task< List<CommunitiesForOrganization>> GetAllCommunitiesForOrganizationAsync();
         
    }
}
