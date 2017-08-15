using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsAppTest
{
	public class CustomStart : MvxNavigatingObject, IMvxAppStart
	{
		public void Start(object hint = null)
		{ 
			// TODO get from settings
			ShowViewModel<MainViewModel>();
		}
	}
}
