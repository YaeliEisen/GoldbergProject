
using GoldbergProject.Models;

namespace Repositories.Interfaces
{
    public interface ICommunityrepository
    {
        Task<List<Community>> GetAllCommunitiesAsync();
    }
}
