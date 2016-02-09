using System;

namespace Spinnable
{
	#region EnglishAppLanguage
	public class EnglishAppLanguage : AppLanguage
	{
		public EnglishAppLanguage ()
			: base("English")
		{
			this.AppName = "SPINNABLE";
			this.HomePageLabel = "Home";
			this.SearchPageLabel = "Search";
			this.GalleryPageLabel = "Gallery";
			this.FollowersPageLabel = "Followers";
			this.ProfilePageLabel = "Profile";
			this.LogInPageLabel = "Log In";
			this.SignUpPageLabel = "Sign Up";
			this.ForgotPageLabel = "Forgot Password";
			this.EditProfilePageLabel = "Edit Profile";

			this.LogInWelcomeText = "Sign up to see 360° photos and videos from the Spinnable community";
			this.ForgotWelcomeText = "We well send you a new password on your Email.";

			this.UserNamePlaceholder = "Username";
			this.PasswordPlaceholder = "Password";
			this.EmailPlaceholder = "Enter your Email";

			this.LogInButtonText = "LOG IN";
			this.SignUpButtonText = "SIGN UP";
			this.ForgottenButtonText = "Forgotten password?";
			this.SendButtonText = "SEND";
			this.ChangePasswordButtonText = "Change Password";

			this.PostsLabelText = "Posts:";
			this.FollowersLabelText = "Followers:";
			this.FollowingsLabelText = "Following:";
			this.UserNameLabelText = "User name:";
			this.EMailLabelText = "EMail:";
			this.DisplayNameLabelText = "Display name:";
		}
	}
	#endregion
}

