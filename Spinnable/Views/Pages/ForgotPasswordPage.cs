using System;

using Xamarin.Forms;

namespace Spinnable
{
	#region ForgotPasswordPage
	public class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage ()
		{
			this.SetBinding (Page.TitleProperty, "Title", BindingMode.TwoWay);

			NavigationPage.SetTitleIcon (this, PlatformHelper.MessageImageSource);

			this.BackgroundColor = PlatformHelper.ContentPageColor;
			this.BackgroundImage = PlatformHelper.BackgroundImageSource;

			var forgotTextLabel = new Label {
				TextColor = Color.White,
				HorizontalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.Center,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
			};
			forgotTextLabel.SetBinding (Label.TextProperty, new Binding ("ForgotWelcomeText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var forgotTextContent = new ContentView {
				Padding = new Thickness(10, 0, 10, 10),
				Content = forgotTextLabel
			};

			var emailEntry = new Entry {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Entry))
			};
			emailEntry.SetBinding (Entry.TextProperty, "EMail", BindingMode.TwoWay);
			emailEntry.SetBinding (Entry.PlaceholderProperty, new Binding ("EmailPlaceholder", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));

			var emailContent = new ContentView {
				Padding = new Thickness(10, 75, 10, 10),
				Content = emailEntry
			};

			var busyIndicator = new ActivityIndicator { 
			};
			busyIndicator.SetBinding (ActivityIndicator.IsRunningProperty, "IsBusy", BindingMode.TwoWay);

			var editorLayout = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					forgotTextContent,
					emailEntry,
					busyIndicator
				}
			};

			var sendButton = new Button { 
			};
			sendButton.SetBinding (Button.TextProperty, new Binding ("SendButtonText", BindingMode.TwoWay, null, null, null, AppLanguages.CurrentLanguage));
			sendButton.SetBinding (Button.CommandProperty, "SendCommand");

			var sendContent = new ContentView { 
				Padding = new Thickness(10),
				Content = sendButton
			};

			var grid = new Grid {
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
			grid.Children.Add (editorLayout, 0, 0);
			grid.Children.Add (sendButton, 0, 1);

			this.Content = grid;
		}
	}
	#endregion
}


