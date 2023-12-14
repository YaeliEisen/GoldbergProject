using DTOs;
using GoldbergProject.Models;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {

        private readonly ProjectContext _context;
        public OrganizationRepository(ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Organization>> GetAllOrganizationsAsync()
        {
            List<Organization> listOfOrganizations = _context.Organizations.ToList();
            return listOfOrganizations;
        }
        public async Task<Organization> GetOrganizationByNameAsync(string name)
        {
            return _context.Organizations.ToList().Find(o => o.OrganizationName.Equals(name));
        }
    }
}
