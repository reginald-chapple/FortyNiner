using FortyNiner.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FortyNiner.Web.Data.EntityConfigurations
{
    public class ChatUserConfiguration : IEntityTypeConfiguration<ChatUser>
    {
        public void Configure(EntityTypeBuilder<ChatUser> builder)
        {
            builder.HasKey(x => new { x.ChatId, x.UserId });

            builder.HasOne(x => x.Chat)
                .WithMany(a => a.Users)
                .HasForeignKey(x => x.ChatId)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(a => a.Chats)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
        }
    }
}