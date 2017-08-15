using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Uwp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;

namespace XamFormsAppTest.UWP
{
	public class Setup : MvxFormsWindowsSetup
	{
		public Setup(Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame, e)
		{
		}

		protected override MvxFormsApplication CreateFormsApplication()
		{
			return new XamFormsAppTest.App();
		}

		protected override IMvxApplication CreateApp()
		{
			return new CoreApp() as IMvxApplication;
		}
	}
}
