using AutoMapper;
using DTOs;
using GoldbergProject.Models;
using Services.Interfaces;


namespace Services.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public OrganizationService(IOrganizationRepository organizationRepository,IMapper mapper)
        {
            _organizationRepository = organizationRepository;
            _mapper = mapper;
        }

        public async Task<List<OrganizationDTO>> GetAllOrganizationsAsync()
        {
            return _mapper.Map<List<OrganizationDTO>>(await _organizationRepository.GetAllOrganizationsAsync());
        }

        public async Task<OrganizationDTO> GetOrganizationByNameAsync(string name)
        {
            return _mapper.Map<OrganizationDTO>(await _organizationRepository.GetOrganizationByNameAsync(name));
        }
    }
}
