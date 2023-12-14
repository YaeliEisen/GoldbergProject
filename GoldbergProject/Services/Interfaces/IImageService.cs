using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IImageService
    {
        Task<List<ImageDTO>> GetAllImagesAsync();
        Task<List<ImageDTO>> GetAllImagesWhitOutLogoByOrganizationIdAsync(int organizationId);
        Task<ImageDTO> GetLogoByOrganizationIdAsync(int organizationId);
    }
}
