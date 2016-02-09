using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region MainMenuPage
	public class MainMenuPage : ContentPage
	{
		public MainMenuPage ()
		{
			this.Title = AppLanguages.CurrentLanguage.AppName;
			this.Icon = PlatformHelper.MenuImageSource;

			this.BackgroundColor = PlatformHelper.MenuPageColor;

			var titleLabel = new Label {
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			titleLabel.SetBinding(Label.TextProperty, "Title", BindingMode.TwoWay);

			var titleLabelView = new ContentView {
				Padding = new Thickness (30, 50, 0, 50),
				Content = titleLabel
			};

			var mainMenuListView = new MainMenuListView { 
			};
			mainMenuListView.SetBinding (ItemsView<Cell>.ItemsSourceProperty, "Items", BindingMode.TwoWay);
			mainMenuListView.SetBinding (ListView.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
			mainMenuListView.SetBinding (BaseListView.ItemClickCommandProperty, "SelectItemCommand");

			this.Content = new StackLayout { 
				Children = {
					titleLabelView,
					mainMenuListView
				}
			};
		}
	}
	#endregion
}


