using System;
using Parse;

namespace Spinnable
{
	#region Settings
	public class Settings : BaseAPIData
	{
		public Settings ()
			: base()
		{
		}

		public Settings(ParseObject parseData) 
			: base(parseData)
		{
		}

		public override void FillIn (ParseObject parseData)
		{
			if (parseData != null) 
			{
				base.FillIn (parseData);

				if (parseData.ContainsKey ("userObjectID"))
					this.UserObjectID = (string)parseData ["userObjectID"];
				if (parseData.ContainsKey ("isNotiticationEnabled"))
					this.IsNotiticationEnabled = (bool)parseData ["isNotiticationEnabled"];
			}
		}

		public override void FillOut (ParseObject parseData)
		{
			if (parseData != null) 
			{
				base.FillOut (parseData);

				parseData ["userObjectID"] = this.UserObjectID;
				parseData ["isNotiticationEnabled"] = this.IsNotiticationEnabled;
			}
		}

		public string UserObjectID
		{
			get { return (string)this.GetValue ("UserObjectID"); }
			set { this.SetValue ("UserObjectID", value); }
		}

		public bool IsNotiticationEnabled
		{
			get { return (bool)this.GetValue ("IsNotiticationEnabled", false); }
			set { this.SetValue ("IsNotiticationEnabled", value); }
		}
	}
	#endregion
}

