using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region SignUpPage
	public class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.LogInImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			var appNameLabel = new Label { 
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
			};
			appNameLabel.SetBinding (Label.TextProperty, new Binding ("AppName", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var appNameContent = new ContentView { 
				Padding = new Thickness(10, 20, 5, 10),
				Content = appNameLabel
			};

			var logInTextLabel = new Label { 
				TextColor = Color.White,
				HorizontalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.Center,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			};
			logInTextLabel.SetBinding (Label.TextProperty, new Binding ("LogInWelcomeText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var logInTextContent = new ContentView {
				Padding = new Thickness(10, 5, 10, 10),
				Content = logInTextLabel
			};

			var titleLayout = new StackLayout { 
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = {
					appNameContent,
					logInTextContent
				}
			};

			var userNameEntry = new Entry {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry))
			};
			userNameEntry.SetBinding (Entry.TextProperty, "UserName", BindingMode.TwoWay);
			userNameEntry.SetBinding (Entry.PlaceholderProperty, new Binding ("UserNamePlaceholder", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var userNameContent = new ContentView {
				Padding = new Thickness(10, 0, 10, 10),
				Content = userNameEntry
			};

			var emailEntry = new Entry {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry))
			};
			emailEntry.SetBinding (Entry.TextProperty, "EMail", BindingMode.TwoWay);
			emailEntry.SetBinding (Entry.PlaceholderProperty, new Binding ("EmailPlaceholder", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var emailContent = new ContentView {
				Padding = new Thickness(10, 0, 10, 10),
				Content = emailEntry
			};

			var passwordEntry = new Entry {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry)),
				IsPassword = true
			};
			passwordEntry.SetBinding (Entry.TextProperty, "Password", BindingMode.TwoWay);
			passwordEntry.SetBinding (Entry.PlaceholderProperty, new Binding ("PasswordPlaceholder", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var passwordContent = new ContentView {
				Padding = new Thickness(10, 0, 10, 0),
				Content = passwordEntry
			};

			var busyIndicator = new ActivityIndicator { 
			};
			busyIndicator.SetBinding (ActivityIndicator.IsRunningProperty, "IsBusy", BindingMode.TwoWay);

			var editorLayout = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					userNameContent,
					emailContent,
					passwordContent,
					busyIndicator
				}
			};

			var signInButton = new Button { 
			};
			signInButton.SetBinding (Button.TextProperty, new Binding ("SignUpButtonText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));
			signInButton.SetBinding (Button.CommandProperty, "SignUpCommand");

			var signInContent = new ContentView { 
				Padding = new Thickness(10),
				Content = signInButton
			};

			var grid = new Grid { 
				RowSpacing = 0,
				ColumnSpacing = 0,
				RowDefinitions = 
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },					
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },					
					new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
				},
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand	
			};
			grid.Children.Add (titleLayout, 0, 0);
			grid.Children.Add (editorLayout, 0, 1);
			grid.Children.Add (signInContent, 0, 2);

			this.Content = grid;
		}
	}
	#endregion
}


