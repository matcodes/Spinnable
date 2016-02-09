using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region FollowersPage
	public class FollowersPage : ContentPage
	{
		public FollowersPage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			NavigationPage.SetTitleIcon (this, PlatformHelper.FollowersImageSource);

			this.Content = new StackLayout { 
				Children = {
				}
			};
		}
	}
	#endregion
}


