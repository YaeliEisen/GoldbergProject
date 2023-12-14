namespace GoldbergProject.Models
{
    public interface IOrganizationRepository
    {
        Task<List<Organization>> GetAllOrganizationsAsync();
        Task<Organization> GetOrganizationByNameAsync(string name);
    }
}
