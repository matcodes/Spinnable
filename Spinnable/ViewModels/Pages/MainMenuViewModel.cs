using System;
using Java.Util;
using System.Collections.Generic;

namespace Spinnable
{
	#region MainMenuViewModel
	public class MainMenuViewModel : BaseViewModel
	{
		private Dictionary<AppContext, MainMenuItem> _items = new Dictionary<AppContext, MainMenuItem> ();

		public MainMenuViewModel () 
			: base(AppLanguages.CurrentLanguage.AppName, "")
		{
			_items.Add (AppContext.Home, new MainMenuItem { Icon = PlatformHelper.HomeImageSource, AppContext = AppContext.Home });
			_items.Add (AppContext.Search, new MainMenuItem { Icon = PlatformHelper.SearchImageSource, AppContext = AppContext.Search });
			_items.Add (AppContext.Gallery, new MainMenuItem { Icon = PlatformHelper.GalleryImageSource, AppContext = AppContext.Gallery });
			_items.Add (AppContext.Followers, new MainMenuItem { Icon = PlatformHelper.FollowersImageSource, AppContext = AppContext.Followers });
			_items.Add (AppContext.Profile, new MainMenuItem { Icon = PlatformHelper.ProfileImageSource, AppContext = AppContext.Profile });

			this.PrepareLanguage ();

			this.SelectedItem = _items [AppContext.Home];

			this.SelectItemCommand = new VisualCommand (this.SelectItem);
		}

		private void SelectItem(object parameter)
		{
			ShowPageMessage.Send (this.SelectedItem.AppContext);
		}

		private void PrepareLanguage()
		{
			_items [AppContext.Home].Name = AppLanguages.CurrentLanguage.HomePageLabel;
			_items [AppContext.Search].Name = AppLanguages.CurrentLanguage.SearchPageLabel;
			_items [AppContext.Gallery].Name = AppLanguages.CurrentLanguage.GalleryPageLabel;
			_items [AppContext.Followers].Name = AppLanguages.CurrentLanguage.FollowersPageLabel;
			_items [AppContext.Profile].Name = AppLanguages.CurrentLanguage.ProfilePageLabel;
		}

		public MainMenuItem[] Items 
		{
			get { return new List<MainMenuItem> (_items.Values).ToArray (); }
		}

		public MainMenuItem SelectedItem
		{
			get { return (this.GetValue ("SelectedItem") as MainMenuItem); }
			set { this.SetValue ("SelectedItem", value); }
		}

		public VisualCommand SelectItemCommand { get; private set; }
	}
	#endregion

	#region MainMenuItem
	public class MainMenuItem 
	{
		public string Name { get; set; }

		public string Icon { get; set; }

		public AppContext AppContext { get; set; }
	}
	#endregion
}

