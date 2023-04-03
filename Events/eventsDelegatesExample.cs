using System;
using System.Threading;

namespace TestingConsoleApp.Events
{
	public class MailService
	{
		public void onVideoEncoded(object source, EventArgs e)
		{
			Console.WriteLine("Sending an email...");
		}
	}

	public class VideoEventArgs : EventArgs
	{
		public Video video { get; set; }
	}

	// 1- Define a delegate 
	// 2- Define an event based on that event 
	// 3- Raise that event
	public class VideoEncoder
	{
		// public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

		public event EventHandler<VideoEventArgs> VideoEncoded;
		public void Encode(Video video)
		{
			Console.WriteLine("Encoding works..");
			Thread.Sleep(3000);
			onVideoEncoded(video);
		}

		protected virtual void onVideoEncoded(Video video)
		{
			if (VideoEncoded != null)
			{
				VideoEncoded(this, new VideoEventArgs() { video = video });
			}
		}

	}
}
