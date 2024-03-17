using FortyNiner.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FortyNiner.Web.Data.EntityConfigurations
{
    public class EmployeeDeploymentConfiguration : IEntityTypeConfiguration<EmployeeDeployment>
    {
        public void Configure(EntityTypeBuilder<EmployeeDeployment> builder)
        {
            builder.HasKey(x => new { x.EmployeeId, x.DeploymentId });

            builder.HasOne(x => x.Employee)
                .WithMany(a => a.Deployments)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();

            builder.HasOne(x => x.Deployment)
                .WithMany(a => a.Employees)
                .HasForeignKey(x => x.DeploymentId)
                .IsRequired();
        }
    }
}