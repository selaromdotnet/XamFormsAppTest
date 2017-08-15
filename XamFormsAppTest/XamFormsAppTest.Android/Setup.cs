using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace XamFormsAppTest.Droid
{
	public class Setup : MvxFormsAndroidSetup
	{
		public Setup(Context applicationContext) : base(applicationContext) { }

		protected override MvxFormsApplication CreateFormsApplication()
		{
			return new App();
		}

		protected override IMvxApplication CreateApp()
		{

			var app = new CoreApp();
			return app;
		}

		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}

	public class DebugTrace : IMvxTrace
	{
		public void Trace(MvxTraceLevel level, string tag, Func<string> message)
		{
			System.Diagnostics.Debug.WriteLine(tag + ":" + level + ":" + message());
		}

		public void Trace(MvxTraceLevel level, string tag, string message)
		{
			System.Diagnostics.Debug.WriteLine(tag + ":" + level + ":" + message);
		}

		public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
		{
			try
			{
				System.Diagnostics.Debug.WriteLine(string.Format(tag + ":" + level + ":" + message, args));
			}
			catch (FormatException)
			{
				Trace(MvxTraceLevel.Error, tag, "Exception during trace of {0} {1}", level, message);
			}
		}
	}
}