using System;
using System.Threading.Tasks;

namespace Spinnable
{
	#region LogInViewModel
	public class LogInViewModel : BaseViewModel
	{
		private AppContext _nextContext = AppContext.Home;

		public LogInViewModel ()
			: base(AppLanguages.CurrentLanguage.LogInPageLabel, "")
		{
			this.ForgottenCommand = new VisualCommand (this.Forgotten);
			this.LogInCommand = new VisualCommand (this.LogIn);
			this.SignInCommand = new VisualCommand (this.SignIn);
		}

		public override async Task Initialize (params object[] parameters)
		{
			foreach (var obj in parameters)
				if (obj is AppContext) {
					_nextContext = (AppContext)obj;
					break;
				}

			await base.Initialize ();
		}

		private void Forgotten(object parameter)
		{
			PushPageMessage.Send (AppContext.ForgotPassword, null);
		}

		private async void LogIn(object parameter)
		{
			this.IsBusy = true;
			var isLogin = await APIClient.LogIn (this.UserName, this.Password);
			this.IsBusy = false;		

			if (isLogin)
				ShowPageMessage.Send (_nextContext);
		}

		private void SignIn(object parameter)
		{
			PushPageMessage.Send (AppContext.SignUp, null);
		}

		public string UserName
		{
			get { return (string)this.GetValue ("UserName"); }
			set { this.SetValue ("UserName", value); }
		}

		public string Password
		{
			get { return (string)this.GetValue ("Password"); }
			set { this.SetValue ("Password", value); }
		}

		public bool IsBusy
		{
			get { return (bool)this.GetValue ("IsBusy", false); }
			set { this.SetValue ("IsBusy", value); }
		}

		public VisualCommand ForgottenCommand { get; private set; }

		public VisualCommand LogInCommand { get; private set; }

		public VisualCommand SignInCommand { get ; private set; }
	}
	#endregion
}

