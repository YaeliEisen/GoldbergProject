using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityService _communityService;
        public CommunityController(ICommunityService communityService)
        {
            _communityService = communityService;
        }

        [HttpGet]
        public async Task<List<CommunityDTO>> GetAllCommunitiesAsync()
        {
            return await _communityService.GetAllCommunitiesAsync();
        }
        [HttpGet("{id}")]
        public async Task<CommunityDTO> GetNameCommunityByIdAsync(int id)
        {
            return await _communityService.GetNameCommunityByIdAsync(id);
        }
    }
}
