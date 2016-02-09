using System;

namespace Spinnable
{
	#region EditProfileViewModel
	public class EditProfileViewModel : BaseViewModel
	{
		public EditProfileViewModel ()
			: base(AppLanguages.CurrentLanguage.EditProfilePageLabel, "")
		{
			this.ChangePasswordCommand = new VisualCommand (this.ChangePassword);
			this.SaveCommand = new VisualCommand (this.Save);
		}

		public override async System.Threading.Tasks.Task Initialize (params object[] parameters)
		{
			this.User = null;
			var user = (parameters [0] as User);
			this.User = user;

			await base.Initialize (parameters);
		}

		protected override void DoPropertyChanged (string propertyName)
		{
			if (propertyName == "User") 
			{
				this.UserName = (this.User != null ? this.User.UserName : "");
				this.EMail = (this.User != null ? this.User.EMail : "");
				this.DisplayName = (this.User != null ? this.User.DisplayName : "");
			}

			base.DoPropertyChanged (propertyName);
		}

		private void ChangePassword(object parameter)
		{
			
		}

		private async void Save(object parameter)
		{
			this.IsBusy = true;

			this.User.UserName = this.UserName;
			this.User.EMail = this.EMail;
			this.User.DisplayName = this.DisplayName;

			await APIClient.SaveUserAsync (this.User);

			UserUpdatedMessage.Send ();

			this.IsBusy = false;

			PopPageMessage.Send ();
		}

		public User User
		{
			get { return (this.GetValue ("User") as User); }
			set { this.SetValue ("User", value); }
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

		public string DisplayName
		{
			get { return (string)this.GetValue ("DisplayName"); }
			set { this.SetValue ("DisplayName", value); }
		}

		public bool IsBusy
		{
			get { return (bool)this.GetValue ("IsBusy", false); }
			set { this.SetValue("IsBusy", value); }
		}

		public VisualCommand ChangePasswordCommand { get; private set; }

		public VisualCommand SaveCommand { get; private set; }
	}
	#endregion
}

