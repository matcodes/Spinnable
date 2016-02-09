using System;
using System.Threading.Tasks;
using System.Threading;
using Parse;

namespace Spinnable
{
	#region APIClient
	public static class APIClient
	{
		private const string __applicationID =  "DR2zNiWzjQ95PMcyDQoi9ujkXUjiP490F9NfYEzg"; // "VVV2Vu3ZfK5kZdmxsalqUDY4PpgRCCPK2VIKB4LA"
		private const string __applicationKey = "e7ufkJAYigRS3zyNP2IVnb8NCzIsT0SezEfKWYYL"; // "FK1fjXMUnrSMkXUtNAUM7C5XC5jWJx2WbxmsUA6Q"

		public static void Initialize()
		{
			ParseClient.Initialize (__applicationID, __applicationKey);

			BecomeUser ();
		}

		public static async Task<bool> LogIn(string userName, string password)
		{
			await ParseUser.LogInAsync(userName, password);

			await SaveSessionToken ();

			IsLogIn = true;
			return IsLogIn;
		}

		public static bool LogOut()
		{
			ParseUser.LogOut ();
			IsLogIn = false;
			return !IsLogIn;
		}

		public static async Task<bool> Send(string email)
		{
			await ParseUser.RequestPasswordResetAsync(email);
			return true;
		}

		public static async Task<bool> SignUp(string userName, string email, string password)
		{
			var user = new ParseUser 
			{
				Username = userName,
				Password = password,
				Email = email
			};

			await user.SignUpAsync ();

			await SaveSessionToken ();

			IsLogIn = true;
			return IsLogIn;
		}

		public static async Task<User> GetSelfUser()
		{
			User user = null;
			if (IsLogIn)
			{
				var userData = await ParseUser.Query.GetAsync(ParseUser.CurrentUser.ObjectId);
				user = new User (userData);
			}
			return user;
		}

		public static async Task<bool> SaveUserAsync(User user)
		{
			user.FillOut (ParseUser.CurrentUser);
			await ParseUser.CurrentUser.SaveAsync ();
			return true;
		}

		public static async Task<bool> SelectMedias()
		{
			var query = ParseObject.GetQuery("Media");
			try
			{
				var results = await query.FindAsync ();

//				var Items = new List<TodoItem> ();
					foreach (var item in results) {
//					Items.Add (FromParseObject (item));
					Console.WriteLine(item.ToString());
					}
			}
			catch (Exception exception) {
				Console.WriteLine (exception.Message);
			}

			return true;		
		}

		private static void BecomeUser()
		{
			var sessionToken = PlatformHelper.SessionToken;
			if (!String.IsNullOrEmpty(sessionToken))
				Task.Run(async () => {
					try
					{
						await ParseUser.BecomeAsync(sessionToken);
						IsLogIn = true;
					}
					catch 
					{
						IsLogIn = false;
					}
				}).Wait();
		}

		private static async Task SaveSessionToken()
		{
			var parseSession = await ParseSession.GetCurrentSessionAsync ();
			var sessionToken = parseSession.SessionToken;
			PlatformHelper.SessionToken = (String.IsNullOrEmpty (sessionToken) ? "" : sessionToken);
		}

		public static bool IsLogIn { get; private set; }
	}
	#endregion
}

