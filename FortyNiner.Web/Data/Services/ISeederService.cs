namespace FortyNiner.Web.Data.Services;

public interface ISeederService
{
    Task SeedUsersAsync();
    Task CreateUserAsync(string fullName, string userName, string email, string password, string role);
    Task CreateRoleAsync(string roleName);
    Task RunAllAsync();
}