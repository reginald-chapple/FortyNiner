using System.ComponentModel;

namespace FortyNiner.Web.Domain;

public class Assignment : Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public AssignmentState State { get; set; }

    public string Section { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string DeploymentId { get; set; } = string.Empty;

    public virtual Deployment? Deployment { get; set; }
}

public enum AssignmentState
{
    [Description("Closed")]
    Closed,
    [Description("Open")]
    Open
}