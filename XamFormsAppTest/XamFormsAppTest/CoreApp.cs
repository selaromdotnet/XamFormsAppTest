using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsAppTest
{
	public class CoreApp : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			//Register extended app startup in IoC container:
			Mvx.ConstructAndRegisterSingleton<IMvxAppStart, CustomStart>();
			var appStart = Mvx.Resolve<IMvxAppStart>();
			RegisterAppStart(appStart);
		}
	}
}
