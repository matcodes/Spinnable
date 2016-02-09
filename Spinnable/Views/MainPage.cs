using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace Spinnable
{
	#region MainPage
	public class MainPage : MasterDetailPage
	{
		private NavigationPage _navigationPage = null;

		public MainPage ()
		{
			ShowPageMessage.Subscribe (this, this.ShowPageAsync);
			PushPageMessage.Subscribe (this, this.PushPageAsync);
			PopPageMessage.Subscribe (this, this.PopPageAsync);

			var mainMenu = new MainMenuPage ();
			mainMenu.SetBinding (BindableObject.BindingContextProperty, "MainMenuViewModel");

			this.Master = mainMenu;

			var emptyPage = new EmptyPage ();
			this.CreateNavigationPage (emptyPage);

			this.BindingContextChanged += async (sender, args) => { 
				await this.SetRootNavigationAsync (AppContext.Home);
			};

			this.BindingContext = new MainViewModel ();
		}

		private async void ShowPageAsync(ShowPageMessage showPageMessage)
		{
			this.IsPresented = false;

			var appContext = showPageMessage.AppContext;
			var parameters = new object[] { appContext };
			if (((appContext == AppContext.Gallery) || (appContext == AppContext.Followers) || (appContext == AppContext.Profile)) && (!APIClient.IsLogIn))
				appContext = AppContext.LogIn;

			await this.SetRootNavigationAsync (appContext, parameters);
		}

		private async void PushPageAsync(PushPageMessage pushPageMessage)
		{
			var page = await ContextHelper.GetPageByAppContextAsync (pushPageMessage.AppContext, pushPageMessage.Parameters);
			if (page != null)
				await _navigationPage.PushAsync (page);
		}

		private async void PopPageAsync(PopPageMessage popPageMessage)
		{
			await _navigationPage.PopAsync ();
		}

		private async Task SetRootNavigationAsync(AppContext appContext, params object[] parameters)
		{
			var page = await ContextHelper.GetPageByAppContextAsync (appContext, parameters);
			this.CreateNavigationPage (page);
		}

		private void CreateNavigationPage(Page page)
		{
			_navigationPage = new AppNavigationPage (page);
			_navigationPage.SetBinding (BindableObject.BindingContextProperty, "NavigationViewModel");

			_navigationPage.BarBackgroundColor = PlatformHelper.TitleColor;
			_navigationPage.BarTextColor = Color.White;

			this.Detail = _navigationPage;
		}
	}
	#endregion
}


