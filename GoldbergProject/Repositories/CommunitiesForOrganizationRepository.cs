using AutoMapper;
using GoldbergProject.Models;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class CommunitiesForOrganizationRepository : ICommunitiesForOrganizationRepository
    {

        private readonly ProjectContext _context;
        readonly IMapper _mapper;
        public CommunitiesForOrganizationRepository(ProjectContext datacontext, IMapper mapper)
        {
            _context  = datacontext;
            _mapper = mapper;
        }

        public async Task<List<CommunitiesForOrganization>> GetAllCommunitiesForOrganizationAsync()
        {
            List<CommunitiesForOrganization> listOfCommunitiesForOrganization = _mapper.Map<List<CommunitiesForOrganization>>(_context.CommunitiesForOrganizations.ToList());
            return listOfCommunitiesForOrganization;
        }


    }
}
