using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XamFormsAppTest.UWP
{
    public sealed partial class MainPage
    {
		public MainPage()
		{
			this.InitializeComponent();
			var start = Mvx.Resolve<IMvxAppStart>();
			start.Start();


		}

		protected async override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);

			MvxFormsPagePresenter presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsPagePresenter;
			this.LoadApplication(presenter.FormsApplication);
		}
	}
}
