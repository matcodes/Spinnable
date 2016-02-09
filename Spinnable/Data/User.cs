using System;
using Parse;

namespace Spinnable
{
	#region User
	public class User : BaseAPIData
	{
		public User ()
		{
			this.Settings = new Settings ();
		}

		public User(ParseObject parseData) 
			: base(parseData)
		{
		}

		public override void FillIn (ParseObject parseData)
		{
			if (parseData != null)
			{
				base.FillIn (parseData);

				if (parseData.ContainsKey("username"))
					this.UserName = (string)parseData ["username"];
				if (parseData.ContainsKey ("bio"))
					this.BIO = (string)parseData ["bio"];
				if (parseData.ContainsKey ("displayName"))
					this.DisplayName = (string)parseData ["displayName"];
				if (parseData.ContainsKey ("email"))
					this.EMail = (string)parseData ["email"];
				if (parseData.ContainsKey ("followsCount"))
					this.FollowsCount = (long)parseData ["followsCount"];
				if (parseData.ContainsKey ("followersCount"))
					this.FollowersCount = (long)parseData ["followersCount"];
				if (parseData.ContainsKey ("postsCount"))
					this.PostsCount = (long)parseData ["postsCount"];

				if (this.Settings == null)
					this.Settings = new Settings ();
				if (parseData.ContainsKey ("settings"))
					this.Settings.FillIn (parseData ["settings"] as ParseObject);
			}
		}

		public override void FillOut (ParseObject parseData)
		{
			if (parseData != null) 
			{
				base.FillOut (parseData);
			
				parseData ["username"] = this.UserName;
				parseData ["bio"] = this.BIO;
				parseData ["displayName"] = this.DisplayName;
				parseData ["email"] = this.EMail;
				parseData ["followsCount"] = this.FollowsCount;
				parseData ["followersCount"] = this.FollowersCount;
				parseData ["postsCount"] = this.PostsCount;

				ParseObject settings = null;
				if (parseData.ContainsKey("settings"))
					settings = (parseData["settings"] as ParseObject);
				if (settings == null)
					settings = new ParseObject ("Settings");
				this.Settings.UserObjectID = this.ID;
				this.Settings.FillOut (settings);

				parseData ["settings"] = settings;
			}
		}

		public string UserName
		{
			get { return (string)this.GetValue ("UserName"); }
			set { this.SetValue ("UserName", value); }
		}

		public string BIO
		{
			get { return (string)this.GetValue ("BIO"); }
			set { this.SetValue ("BIO", value); }
		}

		public string DisplayName
		{
			get { return (string)this.GetValue ("DisplayName"); }
			set { this.SetValue ("DisplayName", value); }
		}

		public string EMail
		{
			get { return (string)this.GetValue ("EMail"); }
			set { this.SetValue ("EMail", value); }
		}

		public long FollowsCount
		{
			get { return (long)this.GetValue ("FollowsCount", (long)0); }
			set { this.SetValue ("FollowsCount", value); }
		}

		public long FollowersCount
		{
			get { return (long)this.GetValue ("FollowersCount", (long)0); }
			set { this.SetValue ("FollowersCount", value); }
		}

		public long PostsCount
		{
			get { return (long)this.GetValue ("PostsCount", (long)0); }
			set { this.SetValue ("PostsCount", value); }
		}

		public Settings Settings { get; private set; }
	}
	#endregion
}

