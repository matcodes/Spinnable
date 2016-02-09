using System;
using System.Threading.Tasks;

namespace Spinnable
{
	#region SignInViewModel
	public class SignUpViewModel : BaseViewModel
	{
		public SignUpViewModel ()
			: base(AppLanguages.CurrentLanguage.SignUpPageLabel, "")
		{
			this.SignUpCommand = new VisualCommand (this.SignUp);
		}

		private async void SignUp(object parameter)
		{
			this.IsBusy = true;
			bool signed = true;
			try
			{
				signed = await APIClient.SignUp (this.UserName, this.EMail, this.Password);
			}
			catch (Exception exception) {
				Console.WriteLine (exception.Message);
//				DisplayAlert ("Alert", "You have been alerted", "OK");
			}
			this.IsBusy = false;
			if (signed)
				ShowPageMessage.Send (AppContext.Profile);
		}

		public string UserName
		{
			get { return (string)this.GetValue ("UserName"); }
			set { this.SetValue ("UserName", value); }
		}

		public string EMail
		{
			get { return (string)this.GetValue ("EMail"); }
			set { this.SetValue ("EMail", value); }
		}

		public string Password 
		{
			get { return (string)this.GetValue ("Password"); }
			set { this.SetValue("Password", value); }
		}

		public bool IsBusy
		{
			get { return (bool)this.GetValue ("IsBusy", false); }
			set { this.SetValue ("IsBusy", value); }
		}

		public VisualCommand SignUpCommand { get; private set; }
	}
	#endregion
}

