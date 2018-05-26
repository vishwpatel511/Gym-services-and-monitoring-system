using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GsmsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminHomePage : ContentPage
	{
		public AdminHomePage ()
		{
			InitializeComponent ();
		}
        private async void ConsultantClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }
    }
}