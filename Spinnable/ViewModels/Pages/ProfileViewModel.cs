using System;
using System.Threading.Tasks;

namespace Spinnable
{
	#region ProfileViewModel
	public class ProfileViewModel : BaseViewModel
	{
		public ProfileViewModel () 
			: base(AppLanguages.CurrentLanguage.ProfilePageLabel, "")
		{
			UserUpdatedMessage.Subscribe (this, this.UserUpdated);

			this.EditCommand = new VisualCommand (this.Edit);
		}

		public override async Task Initialize (params object[] parameters)
		{
			await GetSelfUser ();
		}

		protected override void DoPropertyChanged (string propertyName)
		{
			if (propertyName == "User") 
			{
				this.UserName = (this.User != null ? this.User.DisplayName : null);
				this.Posts = (this.User != null ? this.User.PostsCount : 0);
				this.Followers = (this.User != null ? this.User.FollowersCount : 0);
				this.Followings = (this.User != null ? this.User.FollowsCount : 0);
			}

			base.DoPropertyChanged (propertyName);
		}

		private async Task GetSelfUser()
		{
			this.User = null;
			var user = await APIClient.GetSelfUser ();
			this.User = user;
		}

		private async void UserUpdated(UserUpdatedMessage massage)
		{
			await this.GetSelfUser();
		}

		private void Edit(object parameter)
		{
			PushPageMessage.Send (AppContext.EditProfile, User);
		}

		public User User
		{
			get { return (this.GetValue ("User") as User); }
			set { this.SetValue ("User", value); }
		}

		public string UserName
		{
			get { return (string)this.GetValue ("UserName", "User Of Master"); }
			set { this.SetValue ("UserName", value); }
		}

		public long Posts
		{
			get { return (long)this.GetValue ("Posts", (long)0); }
			set { this.SetValue ("Posts", value); }
		}

		public long Followings
		{
			get { return (long)this.GetValue ("Followings", (long)0); }
			set { this.SetValue ("Followings", value); }
		}

		public long Followers
		{
			get { return (long)this.GetValue ("Followers", (long)0); }
			set { this.SetValue ("Followers", value); }
		}

		public VisualCommand EditCommand { get; private set; }
	}
	#endregion
}

