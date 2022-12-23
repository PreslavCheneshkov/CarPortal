namespace CarPortal.Core.Services.Contracts
{
    public interface IAdminService
    {
        public Task<Tuple<int, int>> GetIndexPageDataAsync();

        public Task<List<string>> GetRolesAsync();

        public Task GiveRole(string roleName, string username);
    }
}
