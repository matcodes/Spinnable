using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace Spinnable
{
	#region ExtendedLabel
	public class ExtendedLabel : Label
	{
		#region Static members
		public static readonly BindableProperty TapCommandProperty = BindableProperty.Create<ExtendedLabel, ICommand>(p => p.TapCommand, null);
		#endregion

		public ExtendedLabel()
		{
		}

		protected override void OnPropertyChanged (string propertyName)
		{
			if (propertyName == "TapCommand") {
				if (this.TapCommand == null)
					this.GestureRecognizers.Clear ();
				else
					this.GestureRecognizers.Add (new TapGestureRecognizer {
						Command = this.TapCommand,
						NumberOfTapsRequired = 1
					});
			}
		}

		public ICommand TapCommand
		{
			get { return (GetValue (TapCommandProperty) as ICommand); }
			set { SetValue (TapCommandProperty, value); }
		}
	}
	#endregion
}

