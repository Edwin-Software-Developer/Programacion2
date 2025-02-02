public class SMSNotificationService
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}