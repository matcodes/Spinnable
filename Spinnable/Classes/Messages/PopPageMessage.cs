using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region PopPageMessage
	public class PopPageMessage
	{
		#region Статические методы
		public static void Send()
		{
			PopPageMessage message = new PopPageMessage ();
			MessagingCenter.Send<PopPageMessage> (message, "PopPageMessage");
		}

		public static void Subscribe(object subscriber, Action<PopPageMessage> action)
		{
			MessagingCenter.Subscribe<PopPageMessage> (subscriber, "PopPageMessage", action);			
		}

		public static void Unsubscribe(object subscriber)
		{
		}
		#endregion

		public PopPageMessage()
		{
		}
	}
	#endregion
}

