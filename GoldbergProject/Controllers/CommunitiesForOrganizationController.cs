using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitiesForOrganizationController : ControllerBase
    {
        private readonly ICommunitiesForOrganizationService _communitiesForOrganizationService;
        public CommunitiesForOrganizationController(ICommunitiesForOrganizationService communitiesForOrganizationService)
        {
            _communitiesForOrganizationService = communitiesForOrganizationService;
        }

        [HttpGet]
        public async Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationAsync()
        {
            return await _communitiesForOrganizationService.GetAllCommunitiesForOrganizationAsync();
        }

        [HttpGet("{id}")]
        public async Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationByOrganizationIdAsync(int id)
        {
            return await _communitiesForOrganizationService.GetAllCommunitiesForOrganizationByOrganizationIdAsync(id);
        }

    }
}
