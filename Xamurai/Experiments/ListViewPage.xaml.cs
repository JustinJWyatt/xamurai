using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamurai.Services;

namespace Xamurai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			BindingContext = new SampleViewModel();
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			DependencyService.Get<IStatusBarService>().HideStatusBar();
		}
    }
}