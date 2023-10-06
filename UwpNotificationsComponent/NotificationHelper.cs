using Microsoft.Toolkit.Uwp.Notifications;

namespace UwpNotificationsComponent
{
    public class NotificationHelper
    {
        public static void SendNotification(DateTime notificationTime, string title, string message)
        {
            // Construct the content for the toast notification
            var content = new ToastContentBuilder()
                .AddText(title)
                .AddText(message)
                .GetToastContent();

            // Create a scheduled toast notification
            var scheduledToast = new ScheduledToastNotification(content.GetXml(), notificationTime)
            {
                Id = "YourNotificationId" // Replace with a unique ID for the notification
            };

            // Schedule the notification
            ToastNotificationManager.CreateToastNotifier().AddToSchedule(scheduledToast);
        }
    }
}