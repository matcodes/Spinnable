using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region PushPageMessage
	public class PushPageMessage
	{
		#region Статические методы
		public static void Send(AppContext appContext, params object[] parameters)
		{
			PushPageMessage message = new PushPageMessage (appContext, parameters);
			MessagingCenter.Send<PushPageMessage> (message, "PushPageMessage");
		}

		public static void Subscribe(object subscriber, Action<PushPageMessage> action)
		{
			MessagingCenter.Subscribe<PushPageMessage> (subscriber, "PushPageMessage", action);			
		}

		public static void Unsubscribe(object subscriber)
		{
		}
		#endregion

		public PushPageMessage(AppContext appContext, params object[] parameters)
		{
			this.AppContext = appContext;
			this.Parameters = parameters;
		}

		public AppContext AppContext { get; private set; }

		public object[] Parameters { get; private set; }
	}
	#endregion
}

