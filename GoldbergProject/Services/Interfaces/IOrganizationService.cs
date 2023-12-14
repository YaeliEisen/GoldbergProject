using DTOs;


namespace Services.Interfaces
{
    public interface IOrganizationService
    {
        Task<List<OrganizationDTO>> GetAllOrganizationsAsync();
        Task<OrganizationDTO> GetOrganizationByNameAsync(string name);
    }
}
