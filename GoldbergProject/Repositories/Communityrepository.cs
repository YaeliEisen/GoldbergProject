using GoldbergProject.Models;
using Repositories.Interfaces;


namespace Repositories.Repositories
{
    public class Communityrepository : ICommunityrepository
    {
        private readonly ProjectContext _context;
        public Communityrepository(ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Community>> GetAllCommunitiesAsync()
        {
            List<Community> listOflCommunities = _context.Communities.ToList();
            return listOflCommunities;
        }

    }
}
