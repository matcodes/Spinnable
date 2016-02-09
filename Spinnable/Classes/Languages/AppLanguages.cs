using System;
using System.Collections.Generic;

namespace Spinnable
{
	#region IAppLanguage
	public class AppLanguage : BaseData
	{
		public AppLanguage(string displayName) 
			: base()
		{
			this.DisplayName = displayName;
		}

		public void Assign(AppLanguage language)
		{
			if (language != null) {
				this.DisplayName = language.DisplayName;
				this.AppName = language.AppName;
				this.HomePageLabel = language.HomePageLabel;
				this.SearchPageLabel = language.SearchPageLabel;
				this.GalleryPageLabel = language.GalleryPageLabel;
				this.FollowersPageLabel = language.FollowersPageLabel;
				this.ProfilePageLabel = language.ProfilePageLabel;
				this.LogInPageLabel = language.LogInPageLabel;
				this.SignUpPageLabel = language.SignUpPageLabel;
				this.ForgotPageLabel = language.ForgotPageLabel;
				this.EditProfilePageLabel = language.EditProfilePageLabel;

				this.LogInWelcomeText = language.LogInWelcomeText;
				this.ForgotWelcomeText = language.ForgotWelcomeText;

				this.UserNamePlaceholder = language.UserNamePlaceholder;
				this.PasswordPlaceholder = language.PasswordPlaceholder;
				this.EmailPlaceholder = language.EmailPlaceholder;

				this.LogInButtonText = language.LogInButtonText;
				this.SignUpButtonText = language.SignUpButtonText;
				this.ForgottenButtonText = language.ForgottenButtonText;
				this.SendButtonText = language.SendButtonText;
				this.ChangePasswordButtonText = language.ChangePasswordButtonText;

				this.PostsLabelText = language.PostsLabelText;
				this.FollowersLabelText = language.FollowersLabelText;
				this.FollowingsLabelText = language.FollowingsLabelText;
				this.UserNameLabelText = language.UserNameLabelText;
				this.EMailLabelText = language.EMailLabelText;
				this.DisplayNameLabelText = language.DisplayNameLabelText;
			}
		}

		public string DisplayName { get; private set; }

		public string AppName
		{
			get { return (string)this.GetValue ("AppName"); }
			set { this.SetValue ("AppName", value); }
		}

		public string HomePageLabel
		{
			get { return (string)this.GetValue ("HomePageName"); }
			set { this.SetValue ("HomePageName", value); }
		}

		public string SearchPageLabel
		{
			get { return (string)this.GetValue ("SearchPageLabel"); }
			set { this.SetValue ("SearchPageLabel", value); }
		}

		public string GalleryPageLabel
		{
			get { return (string)this.GetValue ("GalleryPageLabel"); }
			set { this.SetValue ("GalleryPageLabel", value); }
		}

		public string FollowersPageLabel
		{
			get { return (string)this.GetValue ("FallowersPageLabel"); }
			set { this.SetValue ("FallowersPageLabel", value); }
		}

		public string ProfilePageLabel
		{
			get { return (string)this.GetValue ("ProfilePageLabel"); }
			set { this.SetValue ("ProfilePageLabel", value); }
		}

		public string LogInPageLabel
		{
			get { return (string)this.GetValue ("LogInPageLabel"); }
			set { this.SetValue ("LogInPageLabel", value); }
		}

		public string SignUpPageLabel
		{
			get { return (string)this.GetValue ("SignUpPageLabel"); }
			set { this.SetValue ("SignUpPageLabel", value); }
		}

		public string ForgotPageLabel
		{
			get { return (string)this.GetValue ("ForgotPageLabel"); }
			set { this.SetValue ("ForgotPageLabel", value); }
		}

		public string EditProfilePageLabel
		{
			get { return (string)this.GetValue ("EditProfilePageLabel"); }
			set { this.SetValue ("EditProfilePageLabel", value); }
		}

		public string LogInWelcomeText 
		{
			get { return (string)this.GetValue ("LogInWelcomeText"); }
			set { this.SetValue ("LogInWelcomeText", value); }
		}

		public string ForgotWelcomeText 
		{
			get { return (string)this.GetValue ("ForgotWelcomeText"); }
			set { this.SetValue ("ForgotWelcomeText", value); }
		}

		public string UserNamePlaceholder
		{
			get { return (string)this.GetValue ("UserNamePlaceholder"); }
			set { this.SetValue ("UserNamePlaceholder", value); }
		}

		public string PasswordPlaceholder
		{
			get { return (string)this.GetValue ("PasswordPlaceholder"); }
			set { this.SetValue ("PasswordPlaceholder", value); }
		}

		public string EmailPlaceholder
		{
			get { return (string)this.GetValue ("EmailPlaceholder"); }
			set { this.SetValue ("EmailPlaceholder", value); }
		}

		public string LogInButtonText
		{
			get { return (string)this.GetValue ("LogInButtonText"); }
			set { this.SetValue ("LogInButtonText", value); }
		}
		public string ForgottenButtonText
		{
			get { return (string)this.GetValue ("ForgottenButtonText"); }
			set { this.SetValue ("ForgottenButtonText", value); }
		}

		public string SignUpButtonText
		{
			get { return (string)this.GetValue ("SignUpButtonText"); }
			set { this.SetValue ("SignUpButtonText", value); }
		}

		public string SendButtonText 
		{
			get { return (string)this.GetValue ("SendButtonText"); }
			set { this.SetValue ("SendButtonText", value); }
		}

		public string ChangePasswordButtonText
		{
			get { return (string)this.GetValue ("ChangePasswordButtonText"); }
			set { this.SetValue ("ChangePasswordButtonText", value); }
		}

		public string PostsLabelText
		{
			get { return (string)this.GetValue ("PostsLabelText"); }
			set { this.SetValue ("PostsLabelText", value);}
		}

		public string FollowersLabelText
		{
			get { return (string)this.GetValue ("FollowersLabelText"); }
			set { this.SetValue ("FollowersLabelText", value); }
		}

		public string FollowingsLabelText
		{
			get { return (string)this.GetValue ("FollowingsLabelText"); }
			set { this.SetValue ("FollowingsLabelText", value); }
		}

		public string UserNameLabelText
		{
			get { return (string)this.GetValue ("UserNameLabelText"); }
			set { this.SetValue ("UserNameLabelText", value); }
		}

		public string EMailLabelText
		{
			get { return (string)this.GetValue ("EMailLabelText"); }
			set { this.SetValue ("EMailLabelText", value); }
		}

		public string DisplayNameLabelText
		{
			get { return (string)this.GetValue ("DisplayNameLabelText"); }
			set { this.SetValue ("DisplayNameLabelText", value); }
		}
	}
	#endregion

	#region AppLanguages
	public static class AppLanguages
	{
		private static Dictionary<string, AppLanguage> __languages = new Dictionary<string, AppLanguage>();

		static AppLanguages()
		{
			CurrentLanguage = new AppLanguage ("");

			AddLanguage (new EnglishAppLanguage ());
			AddLanguage (new RussianAppLanguage ());

			SetLanguage ("English");
		}

		public static void SetLanguage(string languageDisplayName)
		{
			if ((CurrentLanguage == null) || (CurrentLanguage.DisplayNameLabelText != languageDisplayName)) {
				AppLanguage language = null;
				if (__languages.TryGetValue (languageDisplayName, out language)) 
					CurrentLanguage.Assign(language);
			}
		}

		private static void AddLanguage(AppLanguage appLanguage)
		{
			__languages.Add (appLanguage.DisplayName, appLanguage);
		}

		public static AppLanguage CurrentLanguage { get; private set; }
	}
	#endregion
}

