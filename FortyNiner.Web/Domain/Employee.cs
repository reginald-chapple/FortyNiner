using System.ComponentModel.DataAnnotations;

namespace FortyNiner.Web.Domain;

public class Employee : AuditableEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Display(Name = "Full Name")]
    [StringLength(800, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string FullName { get; set; } = string.Empty;

    [Display(Name = "Call Tag")]
    [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
    public string CallTag { get; set; } = string.Empty;

    public ICollection<EmployeeDeployment> Deployments { get; set; } = [];
}