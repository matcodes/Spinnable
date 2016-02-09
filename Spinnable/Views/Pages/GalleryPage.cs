using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region GalleryPage
	public class GalleryPage : ContentPage
	{
		public GalleryPage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.GalleryImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			this.Content = new StackLayout { 
				Children = {
				}
			};
		}
	}
	#endregion
}


