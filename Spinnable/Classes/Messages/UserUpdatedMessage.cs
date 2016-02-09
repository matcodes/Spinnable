using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region UserUpdatedMessage
	public class UserUpdatedMessage
	{
		#region Статические методы
		public static void Send()
		{
			UserUpdatedMessage message = new UserUpdatedMessage ();
			MessagingCenter.Send<UserUpdatedMessage> (message, "UserUpdatedMessage");
		}

		public static void Subscribe(object subscriber, Action<UserUpdatedMessage> action)
		{
			MessagingCenter.Subscribe<UserUpdatedMessage> (subscriber, "UserUpdatedMessage", action);			
		}

		public static void Unsubscribe(object subscriber)
		{
		}
		#endregion

		public UserUpdatedMessage()
		{
		}
	}
	#endregion
}

