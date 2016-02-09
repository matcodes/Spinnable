using System;
using Xamarin.Forms;

namespace Spinnable
{
	#region MainMenuListView
	public class MainMenuListView : BaseListView
	{
		public MainMenuListView ()
		{
			this.BackgroundColor = Color.Transparent;

			this.ItemTemplate = new DataTemplate (typeof(MainMenuCell));
		}
	}
	#endregion

	#region MenuItemCell
	public class MainMenuCell : ViewCell
	{
		public MainMenuCell()
			:base()
		{
			var image = new Image {
			};
			image.SetBinding (Image.SourceProperty, "Icon");

			var text = new Label {
				TextColor = PlatformHelper.LabelForeColor,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
				VerticalOptions = LayoutOptions.Center
			};
			text.SetBinding(Label.TextProperty, "Name");

			var grid = new Grid {
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				}
			};
			grid.Children.Add(image, 0, 0);
			grid.Children.Add(text, 1, 0);

			var content = new ContentView { 
				Padding = new Thickness(10),
				Content = grid
			};

			this.View = content;
		}
	}
	#endregion
}

