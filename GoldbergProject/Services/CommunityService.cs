using AutoMapper;
using DTOs;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
    public class CommunityService : ICommunityService
    {
        private readonly ICommunityrepository _communityrepository;
        private readonly IMapper _mapper;
     
        public CommunityService(ICommunityrepository communityrepository, IMapper mapper)
        {
            _communityrepository = communityrepository;
            _mapper = mapper;
        }

        public async Task<List<CommunityDTO>> GetAllCommunitiesAsync()
        {
            return _mapper.Map<List<CommunityDTO>>(await _communityrepository.GetAllCommunitiesAsync());
        }

        public async Task<CommunityDTO> GetNameCommunityByIdAsync(int communityId)
        {
            List<CommunityDTO> listOfcommunities = _mapper.Map<List<CommunityDTO>>(await _communityrepository.GetAllCommunitiesAsync());
            CommunityDTO community = listOfcommunities.Find(community1 => community1.CommunityId == communityId);
            return community;
        }
    }
}
