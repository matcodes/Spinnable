using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region SearchPage
	public class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.SearchImageSource);

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


