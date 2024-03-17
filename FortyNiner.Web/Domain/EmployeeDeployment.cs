namespace FortyNiner.Web.Domain;

public class EmployeeDeployment : Entity
{
    public string EmployeeId { get; set; } = string.Empty;
    public virtual Employee? Employee { get; set; }

    public string DeploymentId { get; set; } = string.Empty;
    public virtual Deployment? Deployment { get; set; }
}
