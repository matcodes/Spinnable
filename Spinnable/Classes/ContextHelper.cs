using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Spinnable
{
	#region ContextHelper
	public static class ContextHelper
	{
		private static Dictionary<AppContext, RuntimeTypeHandle> _viewModelTypes = new Dictionary<AppContext, RuntimeTypeHandle> ();
		private static Dictionary<AppContext, RuntimeTypeHandle> _pageTypes = new Dictionary<AppContext, RuntimeTypeHandle> ();

		private static Dictionary<AppContext, Page> _pages = new Dictionary<AppContext, Page>();

		static ContextHelper() 
		{
			CreateViewModelTypes ();
			CreatePageTypes ();
		}

		public static async Task<Page> GetPageByAppContextAsync(AppContext appContext, params object[] parameters)
		{
			Page page = null;
			if (!_pages.TryGetValue (appContext, out page)) {
				RuntimeTypeHandle pageTypeHandle;
				if (_pageTypes.TryGetValue (appContext, out pageTypeHandle)) {
					RuntimeTypeHandle viewModelTypeHandle;
					if (_viewModelTypes.TryGetValue (appContext, out viewModelTypeHandle)) {
						page = (Activator.CreateInstance (Type.GetTypeFromHandle (pageTypeHandle)) as Page);
						var viewModel = Activator.CreateInstance (Type.GetTypeFromHandle (viewModelTypeHandle));
						if (viewModel != null) {
							page.BindingContext = viewModel;
							_pages.Add (appContext, page);
						}
					}
				}
			}

			if ((page != null) && (page.BindingContext is BaseViewModel))
				await (page.BindingContext as BaseViewModel).Initialize (parameters);
				
			return page;
		}

		private static void CreateViewModelTypes()
		{
			_viewModelTypes.Add (AppContext.Home, typeof(HomeViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.Search, typeof(SearchViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.Gallery, typeof(GalleryViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.Followers, typeof(FollowersViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.Profile, typeof(ProfileViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.LogIn, typeof(LogInViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.ForgotPassword, typeof(ForgotPasswordViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.SignUp, typeof(SignUpViewModel).TypeHandle);
			_viewModelTypes.Add (AppContext.EditProfile, typeof(EditProfileViewModel).TypeHandle);
		}

		private static void CreatePageTypes()
		{
			_pageTypes.Add (AppContext.Home, typeof(HomePage).TypeHandle);
			_pageTypes.Add (AppContext.Search, typeof(SearchPage).TypeHandle);
			_pageTypes.Add (AppContext.Gallery, typeof(GalleryPage).TypeHandle);
			_pageTypes.Add (AppContext.Followers, typeof(FollowersPage).TypeHandle);
			_pageTypes.Add (AppContext.Profile, typeof(ProfilePage).TypeHandle);
			_pageTypes.Add (AppContext.LogIn, typeof(LogInPage).TypeHandle);
			_pageTypes.Add (AppContext.ForgotPassword, typeof(ForgotPasswordPage).TypeHandle);
			_pageTypes.Add (AppContext.SignUp, typeof(SignUpPage).TypeHandle);
			_pageTypes.Add (AppContext.EditProfile, typeof(EditProfilePage).TypeHandle);
		}
	}
	#endregion
}

