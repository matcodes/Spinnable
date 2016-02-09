using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region EditProfilePage
	public class EditProfilePage : ContentPage
	{
		public EditProfilePage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.ProfileImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			var userNameLabel = new Label { 
				TextColor = PlatformHelper.LabelForeColor,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				VerticalOptions = LayoutOptions.Center
			};
			userNameLabel.SetBinding (Label.TextProperty, new Binding ("UserNameLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var userNameContent = new ContentView { 
				Padding = new Thickness(10, 0, 0, 0),
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = userNameLabel
			};

			var userNameEntry = new Entry { 
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
			};
			userNameEntry.SetBinding (Entry.TextProperty, "UserName", BindingMode.TwoWay);

			var userNameEntryContent = new ContentView { 
				Padding = new Thickness(0, 0, 10, 0),
				Content = userNameEntry
			};

			var emailLabel = new Label {
				TextColor = PlatformHelper.LabelForeColor,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				VerticalOptions = LayoutOptions.Center
			};
			emailLabel.SetBinding (Label.TextProperty, new Binding ("EMailLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var emailContent = new ContentView { 
				Padding = new Thickness(10, 0, 0, 0),
				Content = emailLabel,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var emailEntry = new Entry { 
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
			};
			emailEntry.SetBinding (Entry.TextProperty, "EMail", BindingMode.TwoWay);

			var emailEntryContent = new ContentView { 
				Padding = new Thickness(0, 0, 10, 0),
				Content = emailEntry
			};

			var displayNameLabel = new Label {
				TextColor = PlatformHelper.LabelForeColor,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				VerticalOptions = LayoutOptions.Center
			};
			displayNameLabel.SetBinding (Label.TextProperty, new Binding ("DisplayNameLabelText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var displayNameContent = new ContentView { 
				Padding = new Thickness(10, 0, 0, 0),
				Content = displayNameLabel,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var displayNameEntry = new Entry { 
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
			};
			displayNameEntry.SetBinding (Entry.TextProperty, "DisplayName", BindingMode.TwoWay);

			var displayNameEntryContent = new ContentView { 
				Padding = new Thickness(0, 0, 10, 0),
				Content = displayNameEntry
			};

			var changePassword = new Button { 
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			changePassword.SetBinding (Button.TextProperty, new Binding ("ChangePasswordButtonText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));
			changePassword.SetBinding (Button.CommandProperty, "ChangePasswordCommand");

			var changePasswordContent = new ContentView { 
				Padding = new Thickness(10),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Content = changePassword
			};
			Grid.SetColumnSpan (changePasswordContent, 2);

			var grid = new Grid { 
				RowSpacing = 0,
				ColumnSpacing = 10,
				RowDefinitions = 
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },					
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },					
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
				},
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				},
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand	
			};
			grid.Children.Add (userNameContent, 0, 0);
			grid.Children.Add (userNameEntryContent, 1, 0);
			grid.Children.Add (emailContent, 0, 1);
			grid.Children.Add (emailEntryContent, 1, 1);
			grid.Children.Add (displayNameContent, 0, 2);
			grid.Children.Add (displayNameEntryContent, 1, 2);
//			grid.Children.Add (changePasswordContent, 0, 3);

			var content = new ScrollView { 
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = grid
			};

			this.Content = content;

			var saveItem = new ToolbarItem { Icon = PlatformHelper.DownloadImageSource };
			saveItem.SetBinding (Xamarin.Forms.MenuItem.CommandProperty, "SaveCommand");

			this.ToolbarItems.Add (saveItem);
		}
	}
	#endregion
}


