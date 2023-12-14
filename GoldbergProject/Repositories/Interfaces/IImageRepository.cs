
namespace GoldbergProject.Models
{
    public interface IImageRepository
    {
        Task<List<Image>> GetAllImagesAsync();

    }
}
