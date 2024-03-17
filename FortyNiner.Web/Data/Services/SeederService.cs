
using FortyNiner.Web.Domain;
using Microsoft.AspNetCore.Identity;

namespace FortyNiner.Web.Data.Services;

public class SeederService : ISeederService
{
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public SeederService(ApplicationDbContext context, RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _roleManager = roleManager;
        _userManager = userManager;
    }
    public async Task SeedUsersAsync()
    {
        if (!_context.Roles.Any())
        {
            await CreateRoleAsync("Administrator");
            await CreateRoleAsync("Supervisor");
            await CreateRoleAsync("Dispatcher");
        }

        if (!_context.Users.Any())
        {
            await CreateUserAsync("Super User", "sudo@local.com", "sudo@local.com", "P@ss1234", "Administrator");
            await CreateUserAsync("Ayden Ross", "ayden.ross@local.com", "ayden.ross@local.com", "P@ss1234", "Dispatcher");
            await CreateUserAsync("Eddie Moss", "eddie.moss@local.com", "eddie.moss@local.com", "P@ss1234", "Dispatcher");
            await CreateUserAsync("Rosa Santoso", "rosa.santoso@local.com", "rosa.santoso@local.com", "P@ss1234", "Supervisor");
            await CreateUserAsync("Sammy Bear", "sammy.bear@local.com", "sammy.bear@local.com", "P@ss1234", "Supervisor");
        }
    }

    public async Task CreateUserAsync(string fullName, string userName, string email, string password, string role)
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            FullName = fullName,
            UserName = userName,
            Email = email
        };

        await _userManager.CreateAsync(user, password);
        await _userManager.AddToRoleAsync(user, role);
    }

    public async Task CreateRoleAsync(string roleName)
    {
        var role = new ApplicationRole { Id = Guid.NewGuid().ToString(), Name = roleName };
        await _roleManager.CreateAsync(role);
    }

    public async Task RunAllAsync() 
    {
        await SeedUsersAsync();
        await _context.SaveChangesAsync();
    }
}