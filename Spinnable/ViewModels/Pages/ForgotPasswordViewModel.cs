using System;
using System.Threading.Tasks;

namespace Spinnable
{
	#region ForgotPasswordViewModel
	public class ForgotPasswordViewModel : BaseViewModel
	{
		public ForgotPasswordViewModel ()
			: base(AppLanguages.CurrentLanguage.ForgotPageLabel, "")
		{
			this.SendCommand = new VisualCommand (this.Send);
		}

		private async void Send(object parameter)
		{
			this.IsBusy = true;
			var sending = await APIClient.Send (this.EMail);
			this.IsBusy = false;
			if (sending)
				PopPageMessage.Send ();
		}

		public string EMail
		{
			get { return (string)this.GetValue ("EMail"); }
			set { this.SetValue ("EMail", value); }
		}

		public bool IsBusy
		{
			get { return (bool)this.GetValue ("IsBusy", false); }
			set { this.SetValue ("IsBusy", value); }
		}

		public VisualCommand SendCommand { get; private set; }
	}
	#endregion
}

