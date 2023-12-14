using AutoMapper;
using DTOs;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CommunitiesForOrganizationService : ICommunitiesForOrganizationService
    {
        private readonly ICommunitiesForOrganizationRepository _communitiesForOrganizationRepository;
        private readonly IMapper _mapper;
        public CommunitiesForOrganizationService(ICommunitiesForOrganizationRepository communitiesForOrganizationRepository,IMapper mapper)
        {
            _communitiesForOrganizationRepository = communitiesForOrganizationRepository;
            _mapper = mapper;
        }

        public async  Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationAsync()
        {
            var comm = await _communitiesForOrganizationRepository.GetAllCommunitiesForOrganizationAsync();
            return _mapper.Map < List < CommunitiesForOrganizationDTO >> (comm);
        }

        public async Task<List<CommunitiesForOrganizationDTO>> GetAllCommunitiesForOrganizationByOrganizationIdAsync(int organizationid)
        {
            List<CommunitiesForOrganizationDTO> listOAllCommunitiesForOrganizationByOrganizationId = _mapper.Map<List<CommunitiesForOrganizationDTO>>(await _communitiesForOrganizationRepository.GetAllCommunitiesForOrganizationAsync());
            List<CommunitiesForOrganizationDTO> filteredList = listOAllCommunitiesForOrganizationByOrganizationId.FindAll(CommunitiesForOrganization => CommunitiesForOrganization.OrganizationId == organizationid);
            return filteredList;
        }
    }
}
