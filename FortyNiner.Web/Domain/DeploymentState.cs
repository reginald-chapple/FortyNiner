using System.ComponentModel;

namespace FortyNiner.Web.Domain;

public enum DeploymentState
{
    [Description("Pending")]
    Pending,
    [Description("Ongoing")]
    Ongoing,
    [Description("Complete")]
    Complete,
    [Description("Missed")]
    Missed
}