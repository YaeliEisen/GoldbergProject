using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;


namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;
        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        [HttpGet]
        public async Task<List<OrganizationDTO>> GetAllOrganizationsAsync()
        {
            return await _organizationService.GetAllOrganizationsAsync();
        }
        [HttpGet("{name}")]
        public async Task<OrganizationDTO> GetOrganizationByNameAsync(string name)
        {
            return await _organizationService.GetOrganizationByNameAsync(name);
        }
    }
}