using AutoMapper;
using DTOs;
using GoldbergProject.Models;
using Services.Interfaces;

namespace Services.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;
        public ImageService(IImageRepository imageRepository,IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<List<ImageDTO>> GetAllImagesAsync()
        {
            return _mapper.Map < List < ImageDTO >> (await _imageRepository.GetAllImagesAsync());
        }

        public async Task<List<ImageDTO>> GetAllImagesWhitOutLogoByOrganizationIdAsync(int organizationId)
        {
            List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetAllImagesAsync());
            List<ImageDTO> filteredImages = images.FindAll(image => image.ImageOrganizationId == organizationId && image.ImageLogo == false);
            return _mapper.Map<List<ImageDTO>>(filteredImages);
        }


        public async Task<ImageDTO> GetLogoByOrganizationIdAsync(int organizationId)
        {
            List<ImageDTO> images = _mapper.Map<List<ImageDTO>>(await _imageRepository.GetAllImagesAsync());
            ImageDTO filteredImages = images.Find(image => image.ImageOrganizationId == organizationId && image.ImageLogo == true);
            return filteredImages;
        }
    }
}
