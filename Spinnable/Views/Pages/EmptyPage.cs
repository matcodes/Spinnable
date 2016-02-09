using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region EmptyPage
	public class EmptyPage : ContentPage
	{
		public EmptyPage() 
			: base()
		{
			this.SetBinding (Page.TitleProperty, new Binding("AppName", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			NavigationPage.SetTitleIcon (this, PlatformHelper.HomeImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			ContentView content = new ContentView ();

			this.Content = content;
		}
	}
	#endregion
}


