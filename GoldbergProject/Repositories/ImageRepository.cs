using GoldbergProject.Models;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class ImageRepository : IImageRepository
    {

        private readonly ProjectContext _context;
        public ImageRepository(ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Image>> GetAllImagesAsync()
        {
            List<Image> listOfImages = _context.Images.ToList();
            return listOfImages;
        }

    }
}
