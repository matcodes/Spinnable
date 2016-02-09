using System;
using System.Collections.Generic;

namespace Spinnable
{
	#region NavigationViewModel
	public class NavigationViewModel : BaseViewModel
	{
		public NavigationViewModel ()
			: base(AppLanguages.CurrentLanguage.AppName, "")
		{
		}
	}
	#endregion
}

