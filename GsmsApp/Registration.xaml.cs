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
	public partial class Registration : ContentPage
	{
		public Registration ()
		{
			InitializeComponent ();
		}

        private async void accountClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void signupClick(object sender, EventArgs e)
        {
            DisplayAlert("Thank you!","You are registered in the system!","OK");
        }


    }
}