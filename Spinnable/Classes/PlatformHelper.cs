using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region IPlatformHelper
	public interface IPlatformHelper
	{
		#region Session
		string SessionToken { get; set; }
		#endregion

		#region ImageSources
		string SplashImageSource { get; }

		string BackgroundImageSource { get; }

		string NoAvatarImageSource { get;}

		string MenuImageSource { get; }

		string HomeImageSource { get; }

		string SearchImageSource { get; } 

		string GalleryImageSource { get; }

		string FollowersImageSource { get; }

		string ProfileImageSource { get; }

		string LogInImageSource { get; }

		string HelpImageSource { get; }

		string MessageImageSource { get; }

		string EditImageSource { get; }

		string DownloadImageSource { get; }
		#endregion

		#region Colors
		Color TitleColor { get; }

		Color MenuPageColor { get; }

		Color ContentPageColor { get; }

		Color LabelForeColor { get; }
		#endregion
	}
	#endregion

	#region PlatformHelper
	public static class PlatformHelper
	{
		private static IPlatformHelper __platformHelper = null;

		public static void Initialize(IPlatformHelper platformHelper) 
		{
			__platformHelper = platformHelper;

			APIClient.Initialize ();
		}

		#region SessionToken
		public static string SessionToken
		{
			get { return (__platformHelper != null ? __platformHelper.SessionToken : ""); }
			set 
			{
				if (__platformHelper != null)
					__platformHelper.SessionToken = value;
			}
		}
		#endregion

		#region ImageSources
		public static string SplashImageSource
		{
			get { return (__platformHelper != null ? __platformHelper.SplashImageSource : ""); }
		}

		public static string BackgroundImageSource
		{
			get { return (__platformHelper != null ? __platformHelper.BackgroundImageSource : ""); }
		}

		public static string NoAvatarImageSource 
		{
			get { return (__platformHelper != null ? __platformHelper.NoAvatarImageSource : ""); }
		}

		public static string MenuImageSource 
		{ 
			get { return (__platformHelper != null ? __platformHelper.MenuImageSource : ""); }
		}

		public static string HomeImageSource 
		{ 
			get { return (__platformHelper != null ? __platformHelper.HomeImageSource : ""); } 
		}

		public static string SearchImageSource 
		{
			get { return (__platformHelper != null ? __platformHelper.SearchImageSource : ""); }
		}
			
		public static string GalleryImageSource 
		{
			get { return (__platformHelper != null ? __platformHelper.GalleryImageSource : ""); }
		}

		public static string FollowersImageSource
		{
			get { return (__platformHelper != null ? __platformHelper.FollowersImageSource : ""); }
		}

		public static string ProfileImageSource 
		{
			get { return (__platformHelper != null ? __platformHelper.ProfileImageSource : ""); }
		}

		public static string LogInImageSource
		{
			get { return (__platformHelper != null ? __platformHelper.LogInImageSource : ""); }
		}

		public static string HelpImageSource 
		{
			get { return (__platformHelper != null ? __platformHelper.HelpImageSource : ""); }
		}

		public static string MessageImageSource {
			get { return (__platformHelper != null ? __platformHelper.MessageImageSource : ""); }
		}

		public static string EditImageSource {
			get { return (__platformHelper != null ? __platformHelper.EditImageSource : ""); }
		}

		public static string DownloadImageSource {
			get { return (__platformHelper != null ? __platformHelper.DownloadImageSource : ""); }
		}
		#endregion

		#region Colors
		public static Color TitleColor { 
			get { return (__platformHelper != null ? __platformHelper.TitleColor : Color.Default); } 
		}

		public static Color MenuPageColor { 
			get { return (__platformHelper != null ? __platformHelper.MenuPageColor : Color.Default); } 
		}

		public static Color ContentPageColor { 
			get { return (__platformHelper != null ? __platformHelper.ContentPageColor : Color.Default); } 
		}

		public static Color LabelForeColor {
			get { return (__platformHelper != null ? __platformHelper.LabelForeColor : Color.Default); }
		}
		#endregion
	}
	#endregion
}

