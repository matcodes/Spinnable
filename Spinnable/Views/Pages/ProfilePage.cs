using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region ProfilePage
	public class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.ProfileImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			var userAvatarImage = new Image { 
				Source = PlatformHelper.NoAvatarImageSource,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var userNameLabel = new Label { 
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			userNameLabel.SetBinding (Label.TextProperty, "UserName", BindingMode.TwoWay);

			var userNameContent = new ContentView {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.End,
				Padding = new Thickness(10),
				Content = userNameLabel
			};

			var postsTextLabel = new Label { 
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			};
			postsTextLabel.SetBinding (Label.TextProperty, new Binding ("PostsLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var postsTextContent = new ContentView { 
				Padding = new Thickness(5, 10, 0, 10),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.End,
				Content = postsTextLabel
			};

			var postsValueLabel = new Label {
				TextColor = Color.White,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};
			postsValueLabel.SetBinding (Label.TextProperty, "Posts", BindingMode.TwoWay);

			var postsValueContent = new ContentView { 
				Padding = new Thickness(0, 10, 5, 10),
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.End,
				Content = postsValueLabel
			};

			var followersTextLabel = new Label { 
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			};
			followersTextLabel.SetBinding (Label.TextProperty, new Binding ("FollowersLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var followersTextContent = new ContentView { 
				Padding = new Thickness(5, 10, 0, 10),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.End,
				Content = followersTextLabel
			};

			var followersValueLabel = new Label {
				TextColor = Color.White,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};
			followersValueLabel.SetBinding (Label.TextProperty, "Followers", BindingMode.TwoWay);

			var followersValueContent = new ContentView { 
				Padding = new Thickness(0, 10, 5, 10),
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.End,
				Content = followersValueLabel
			};

			var followingsTextLabel = new Label { 
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			};
			followingsTextLabel.SetBinding (Label.TextProperty, new Binding ("FollowingsLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var followingsTextContent = new ContentView { 
				Padding = new Thickness(5, 10, 0, 10),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.End,
				Content = followingsTextLabel
			};

			var followingsValueLabel = new Label {
				TextColor = Color.White,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};
			followingsValueLabel.SetBinding (Label.TextProperty, "Followings", BindingMode.TwoWay);

			var followingsValueContent = new ContentView { 
				Padding = new Thickness(0, 10, 5, 10),
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.End,
				Content = followingsValueLabel
			};

			var valueGrid = new Grid {
				RowSpacing = 0,
				ColumnSpacing = 0,
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				},
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			valueGrid.Children.Add (postsTextContent, 0, 0);
			valueGrid.Children.Add (postsValueContent, 0, 0);
			valueGrid.Children.Add (followersTextContent, 1, 0);
			valueGrid.Children.Add (followersValueContent, 1, 0);
			valueGrid.Children.Add (followingsTextContent, 2, 0);
			valueGrid.Children.Add (followingsValueContent, 2, 0);

			var blogsTextLabel = new Label { 
				TextColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label))
			};

			var contentGrid = new Grid { 
				RowSpacing = 0,
				ColumnSpacing = 0,
				RowDefinitions = 
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },					
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
				},
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand	
			};
			contentGrid.Children.Add (userNameContent, 0, 0);
			contentGrid.Children.Add (userAvatarImage, 0, 0);
			contentGrid.Children.Add (valueGrid, 0, 1);

			this.Content = contentGrid;

			var editItem = new ToolbarItem { Icon = PlatformHelper.EditImageSource };
			editItem.SetBinding (Xamarin.Forms.MenuItem.CommandProperty, "EditCommand");

			this.ToolbarItems.Add (editItem);
		}
	}
	#endregion
}


