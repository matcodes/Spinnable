using System;

namespace Spinnable
{
	#region HomeViewModel
	public class HomeViewModel : BaseViewModel
	{
		public HomeViewModel ()
			: base(AppLanguages.CurrentLanguage.HomePageLabel, "")
		{
		}

		public override async System.Threading.Tasks.Task Initialize (params object[] parameters)
		{
			var result = await APIClient.SelectMedias ();
		}
	}
	#endregion
}

