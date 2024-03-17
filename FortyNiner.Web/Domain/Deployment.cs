using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FortyNiner.Web.Domain;

public class Deployment : Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [DataType(DataType.Text)]
    public string Notes { get; set; } = string.Empty;

    public Shift Shift { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public string SectionId { get; set; } = string.Empty;

    public virtual Section? Section { get; set; }

    public ICollection<EmployeeDeployment> Employees { get; set; } = [];
    public ICollection<Assignment> Assignments { get; set; } = [];
}

public enum Shift
{
    [Description("Day")]
    Day,
    [Description("Swing")]
    Swing,
    [Description("Grave")]
    Grave
}