using System.Security.Claims;
using FortyNiner.Web.Models;

namespace FortyNiner.Web.Data.Services;

public interface IUserService
{
    Task<CreatorModel> GetCreatorAsync(string createdBy);
    Task CreateSuperUserAsync();
    string GetCurrentUserId(ClaimsPrincipal User);
}
