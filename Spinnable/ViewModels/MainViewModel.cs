using System;

namespace Spinnable
{
	#region MainViewModel
	public class MainViewModel : BaseViewModel
	{
		public MainViewModel () 
			: base(AppLanguages.CurrentLanguage.AppName, "")
		{
			this.MainMenuViewModel = new MainMenuViewModel ();
			this.NavigationViewModel = new NavigationViewModel ();
		}

		public MainMenuViewModel MainMenuViewModel { get; private set; }

		public NavigationViewModel NavigationViewModel { get; private set; }
	}
	#endregion
}

