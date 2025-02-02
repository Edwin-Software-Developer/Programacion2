public class NotificationManager
{
    private readonly EmailNotificationService _emailNotificationService;
    private readonly SMSNotificationService _smsNotificationService;
    private readonly NotificationLogService _notificationLogService;

    public NotificationManager()
    {
        _emailNotificationService = new EmailNotificationService();
        _smsNotificationService = new SMSNotificationService();
        _notificationLogService = new NotificationLogService();
    }

    public void SendNotification(int notificationType, string target, string message)
    {
        if (notificationType == 1) 
        {
            _emailNotificationService.SendEmail(target, message);
            _notificationLogService.LogNotification(message);
        }
        else if (notificationType == 2) 
        {
            _smsNotificationService.SendSMS(target, message);
            _notificationLogService.LogNotification(message);
        }
        else
        {
            throw new ArgumentException("Invalid notification type");
        }
    }
}