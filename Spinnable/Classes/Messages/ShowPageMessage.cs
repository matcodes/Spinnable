using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region ShowPageMessage
	public class ShowPageMessage
	{
		#region Статические методы
		public static void Send(AppContext appContext)
		{
			ShowPageMessage message = new ShowPageMessage (appContext);
			MessagingCenter.Send<ShowPageMessage> (message, "ShowPageMessage");
		}

		public static void Subscribe(object subscriber, Action<ShowPageMessage> action)
		{
			MessagingCenter.Subscribe<ShowPageMessage> (subscriber, "ShowPageMessage", action);			
		}

		public static void Unsubscribe(object subscriber)
		{
		}
		#endregion

		public ShowPageMessage(AppContext appContext)
		{
			this.AppContext = appContext;
		}

		public AppContext AppContext { get; private set; }
	}
	#endregion
}

