using System;
using Parse;

namespace Spinnable
{
	#region BaseAPIData
	public class BaseAPIData : BaseData
	{
		public BaseAPIData ()
		{
		}

		public BaseAPIData(ParseObject parseData) 
			:this ()
		{
			this.FillIn (parseData);
		}

		public virtual void FillIn(ParseObject parseData)
		{
			if (parseData != null) 
			{
				this.ID = parseData.ObjectId;
				this.CreateAt = parseData.CreatedAt;
				this.UpdatedAt = parseData.UpdatedAt;
			}
		}

		public virtual void FillOut(ParseObject parseData)
		{
			
		}

		public string ID 
		{
			get { return (string)this.GetValue ("ID"); }
			set { this.SetValue ("ID", value); }
		}

		public DateTime? CreateAt
		{
			get { return (DateTime?)this.GetValue ("CreateAt"); }
			set { this.SetValue ("CreateAt", value); }
		}

		public DateTime? UpdatedAt
		{
			get { return (DateTime?)this.GetValue ("UpdatedAt"); }
			set { this.SetValue ("UpdatedAt", value); }
		}
	}
	#endregion
}

