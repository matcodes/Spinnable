using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region HomePage
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.HomeImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			var grid = new Grid { 
				RowSpacing = 1,
				ColumnSpacing = 1,
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				},
				RowDefinitions = {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },	
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
				}, 
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand	
			};
			grid.Children.Add (this.CreateImage ("img_01"), 0, 0);
			grid.Children.Add (this.CreateImage ("img_02"), 1, 0);
			grid.Children.Add (this.CreateImage ("img_03"), 2, 0);
			grid.Children.Add (this.CreateImage ("img_04"), 0, 1);
			grid.Children.Add (this.CreateImage ("img_05"), 1, 1);
			grid.Children.Add (this.CreateImage ("img_06"), 2, 1);
			grid.Children.Add (this.CreateImage ("img_07"), 0, 2);
			grid.Children.Add (this.CreateImage ("img_08"), 1, 2);
			grid.Children.Add (this.CreateImage ("img_09"), 2, 2);
			grid.Children.Add (this.CreateImage ("img_10"), 0, 3);
			grid.Children.Add (this.CreateImage ("img_11"), 1, 3);
			grid.Children.Add (this.CreateImage ("img_12"), 2, 3);
			grid.Children.Add (this.CreateImage ("img_13"), 0, 4);
			grid.Children.Add (this.CreateImage ("img_14"), 1, 4);
			grid.Children.Add (this.CreateImage ("img_15"), 2, 4);
			grid.Children.Add (this.CreateImage ("img_16"), 0, 5);
			grid.Children.Add (this.CreateImage ("img_17"), 1, 5);
			grid.Children.Add (this.CreateImage ("img_18"), 2, 5);
			grid.Children.Add (this.CreateImage ("img_19"), 0, 6);
			grid.Children.Add (this.CreateImage ("img_20"), 1, 6);

			var scrollView = new ScrollView { 
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Content = grid
			};

			var content = new Grid {
				RowSpacing = 0,
				ColumnSpacing = 0,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand	
			};
			content.Children.Add (scrollView);

			this.Content = content;
		}

		private Image CreateImage(string source)
		{
			var image = new Image {
				Source = source,
				Aspect = Aspect.AspectFill
			};
			image.SizeChanged += (sender, args) => {
//				if (image.HeightRequest == -1)
//					image.HeightRequest = image.Width;
			};
			return image;
		}
	}
	#endregion
}


