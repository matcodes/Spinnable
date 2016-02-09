using System;

namespace Spinnable
{
	#region SearchViewModel
	public class SearchViewModel : BaseViewModel
	{
		public SearchViewModel ()
			: base(AppLanguages.CurrentLanguage.SearchPageLabel, "")
		{
		}
	}
	#endregion
}

