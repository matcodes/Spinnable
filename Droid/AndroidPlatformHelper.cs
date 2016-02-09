using System;
using Xamarin.Forms;
using Android.Content;

namespace Spinnable.Droid
{
	#region AndroidPlatformHelper
	public class AndroidPlatformHelper : IPlatformHelper
	{
		public AndroidPlatformHelper (Context context)
		{
			this.Preferences = context.GetSharedPreferences ("Spinnable.cfg", FileCreationMode.Private);
		}
			
		private ISharedPreferences Preferences { get; set; }

		#region IPlatformHelper implementation
		#region SessionToken
		public string SessionToken
		{
			get 
			{
				var result = this.Preferences.GetString ("SessionToken", "");
				return result;
			}
			set 
			{
				var editor = this.Preferences.Edit ();
				editor.PutString ("SessionToken", value);
				editor.Commit ();
			}
		}
		#endregion

		#region ImageSources
		public string SplashImageSource {
			get { 
				return "Splash";
			}
		}

		public string BackgroundImageSource {
			get { 
				return "Background";
			}
		}

		public string NoAvatarImageSource {
			get { 
				return "NoAvatar";
			}
		}

		public string MenuImageSource {
			get {
				return "MainMenu";
			}
		}

		public string HomeImageSource {
			get {
				return "Home";
			}
		}

		public string SearchImageSource {
			get {
				return "Search";
			}
		}

		public string GalleryImageSource {
			get {
				return "Gallery";
			}
		}

		public string FollowersImageSource {
			get {
				return "Followers";
			}
		}

		public string ProfileImageSource {
			get {
				return "Profile";
			}
		}

		public string LogInImageSource {
			get {
				return "LogIn";
			}
		}

		public string HelpImageSource {
			get { 
				return "Help";
			}
		}

		public string MessageImageSource {
			get { 
				return "Message";
			}
		}

		public string EditImageSource {
			get { 
				return "Edit";
			}
		}

		public string DownloadImageSource {
			get { 
				return "Download";
			}
		}
		#endregion

		#region Colors
		public Color TitleColor { 
			get { 
				return Color.FromRgb (0xFF, 0x8C, 0x00);
			} 
		}

		public Color MenuPageColor { 
			get { 
				return Color.White; // Color.FromRgb (0xFF, 0xB4, 0x00);
			} 
		}

		public Color ContentPageColor { 
			get { 
				return Color.FromRgb (0xFF, 0xDC, 0x00);
			} 
		}

		public Color LabelForeColor {
			get { 
				return Color.Black;
			}
		}
		#endregion
		#endregion
	}
	#endregion
}

