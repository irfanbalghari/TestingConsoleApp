using System;

namespace TestingConsoleApp.Events
{
	public class MessageService
	{
		public void Message(object source, VideoEventArgs e)
		{
			Console.WriteLine("Message Service: " + e.video.Title);
		}
	}
}