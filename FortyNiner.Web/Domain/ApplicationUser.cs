using FortyNiner.Web.Infrastructure.Validation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FortyNiner.Web.Domain;

public class ApplicationUser : IdentityUser<string>
{

    [Display(Name = "Full Name")]
    [StringLength(800, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
    public string FullName { get; set; } = string.Empty;

    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = [];
    public virtual ICollection<UserNotification> Notifications { get; set; } = [];
    public virtual ICollection<ChatUser> Chats { get; set; } = [];
}
