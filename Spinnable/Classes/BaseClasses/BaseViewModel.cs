﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Spinnable
{
	#region BaseViewModel
	public class BaseViewModel : BaseData
	{
		public BaseViewModel (string title, string description)
		{
			this.Errors = new ViewModelErrors ();

			this.Title = title;
			this.Description = description;
		}

		public virtual async Task Initialize(params object[] parameters)
		{
			await Task.Run (() => {
			});
		}

		protected override void DoPropertyChanged(string propertyName)
		{
			this.DoPropertyValidate (propertyName);

			base.DoPropertyChanged (propertyName);
		}

		protected virtual void DoPropertyValidate(string propertyName)
		{
			this.DoSetCommandStates ();
		}

		protected virtual void DoSetCommandStates()
		{
		}

		protected string GetError(string propertyName)
		{
			return this.Errors [propertyName];
		}

		protected void SetError(string propertyName, string errorText)
		{
			this.Errors [propertyName] = errorText;

			this.DoPropertyChanged ("Errors");
		}

		public string Title
		{
			get { return (string)this.GetValue ("Title"); }
			set { this.SetValue ("Title", value); }
		}

		public string Description
		{
			get { return (string)this.GetValue ("Description"); }
			set { this.SetValue ("Description", value); }
		}

		public ViewModelErrors Errors { get; private set; }
	}
	#endregion

	#region ViewModelErrors
	public class ViewModelErrors
	{
		private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

		public ViewModelErrors()
			:base()
		{
		}

		private string GetError(string propertyName)
		{
			string error = "";
			_errors.TryGetValue (propertyName, out error);
			return error;
		}

		private void SetError(string propertyName, string error)
		{
			if (_errors.ContainsKey (propertyName))
				_errors [propertyName] = error;
			else
				_errors.Add (propertyName, error);
		}

		public string this[string propertyName]
		{
			get { return this.GetError (propertyName); }
			set { this.SetError (propertyName, value); }
		}

		public bool HasErrors
		{
			get { return (_errors.Values.Count (s => !string.IsNullOrEmpty (s)) > 0); }
		}
	}
	#endregion
}

