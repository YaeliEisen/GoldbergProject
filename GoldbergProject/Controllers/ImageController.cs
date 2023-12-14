using DTOs;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpGet]
        public async Task<List<ImageDTO>> GetAllImagesAsync()
        {
            return await _imageService.GetAllImagesAsync();
        }
        [HttpGet("{id}")]
        public async Task<List<ImageDTO>> GetAllImagesWhitOutLogoByOrganizationIdAsync(int id)
        {
            return await _imageService.GetAllImagesWhitOutLogoByOrganizationIdAsync(id);
        }
        [HttpGet("logo/{id}")]
        public async Task<ImageDTO> GetLogoByOrganizationIdAsync(int id)
        {
            return await _imageService.GetLogoByOrganizationIdAsync(id);
        }
    }
}

