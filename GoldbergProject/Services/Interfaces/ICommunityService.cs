using DTOs;

namespace Services.Interfaces
{
    public interface ICommunityService
    {
        Task<List<CommunityDTO>> GetAllCommunitiesAsync();
        Task<CommunityDTO> GetNameCommunityByIdAsync(int id);
    }
}
