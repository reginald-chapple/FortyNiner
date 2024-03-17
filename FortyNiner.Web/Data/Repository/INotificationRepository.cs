using FortyNiner.Web.Domain;

namespace FortyNiner.Web.Data.Repository
{
    public interface INotificationRepository
    {
        List<UserNotification> GetUserNotifications(string userId);
            void Create(Notification notification, string receiverId);
            void ReadNotification(int notificationId, string userId);
    }
}