using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace Spinnable
{
	#region BaseListView
	public class BaseListView : ListView
	{
		#region Статические методы
		public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<BaseListView, ICommand>(blv => blv.ItemClickCommand, null);
		#endregion

		public BaseListView ()
			: base()
		{
			VerticalOptions = LayoutOptions.FillAndExpand;

			this.ItemTapped += (sender, args) => {
				if ((args.Item != null) && (this.ItemClickCommand != null) && (this.ItemClickCommand.CanExecute (args.Item))) {
					this.ItemClickCommand.Execute (args.Item);
				};
			};
		}

		public ICommand ItemClickCommand {
			get { return (ICommand)this.GetValue(ItemClickCommandProperty); }
			set { this.SetValue(ItemClickCommandProperty, value); }
		}
	}
	#endregion
}

