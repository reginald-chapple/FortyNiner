#nullable disable
using Microsoft.AspNetCore.Identity;

namespace FortyNiner.Web.Domain
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
