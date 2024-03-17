using System.ComponentModel.DataAnnotations;

namespace FortyNiner.Web.Domain;

public class Section : Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Area { get; set; } = string.Empty;

    [DataType(DataType.Text)]
    public string Locations { get; set; } = string.Empty;

    public ICollection<Deployment> Deployments { get; set; } = [];
}