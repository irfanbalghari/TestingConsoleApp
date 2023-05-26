using System;

namespace TestingConsoleApp
{
	public class DependencyInversionPrinciple
	{
		public static void getStarted()
		{
			// Create an instance of EmailNotification
			INotification emailNotification = new EmailNotification();

			// Create an instance of NotificationService and inject the EmailNotification dependency
			NotificationService emailNotificationService = new NotificationService(emailNotification);

			// Send an email notification
			emailNotificationService.Send("Hello, this is an email notification.");

			// Create an instance of SMSNotification
			INotification smsNotification = new SMSNotification();

			// Create an instance of NotificationService and inject the SMSNotification dependency
			NotificationService smsNotificationService = new NotificationService(smsNotification);

			// Send an SMS notification
			smsNotificationService.Send("Hello, this is an SMS notification.");
			// Create an instance of PushNotification
			INotification pushNotification = new PushNotification();

			// Create an instance of NotificationService and inject the SMSNotification dependency
			NotificationService pushNotificationService = new NotificationService(pushNotification);

			// Send an SMS notification
			pushNotificationService.Send("Hello, this is an Push notification.");
		}
	}
	public interface INotification
	{
		void SendNotification(string message);
	}

	public class EmailNotification : INotification
	{
		public void SendNotification(string message)
		{
			// Send email notification
			Console.WriteLine(message);
		}
	}

	public class SMSNotification : INotification
	{
		public void SendNotification(string message)
		{
			// Send SMS notification
			Console.WriteLine(message);
		}
	}
	public class PushNotification : INotification
	{
		public void SendNotification(string message)
		{
			// Send Push notification
			Console.WriteLine(message);
		}
	}

	public class NotificationService
	{
		private INotification notification;

		public NotificationService(INotification notification)
		{
			this.notification = notification;
		}

		public void Send(string message)
		{
			notification.SendNotification(message);
		}
	}

}
//In this usage example, we first create an instance of EmailNotification and 
//	inject it into the NotificationService constructor, creating an emailNotificationService.We
//	then call the Send method on emailNotificationService to send an email notification.
//Next, we create an instance of SMSNotification and inject it into another instance of 
//	NotificationService, creating an smsNotificationService.We call the Send method on
//	smsNotificationService to send an SMS notification.

//By injecting different implementations of the INotification interface into
//the NotificationService, we can easily switch between sending email notifications
//and SMS notifications without modifying the NotificationService class itself.
//This demonstrates the flexibility and decoupling achieved by
//applying the Dependency Inversion Principle and Dependency Injection.

