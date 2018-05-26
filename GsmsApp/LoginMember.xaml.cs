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
	public partial class LoginMember : ContentPage
	{
		public LoginMember ()
		{
			InitializeComponent ();
		}

        private async void loginBtnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MemberHomePage());
        }

        private async void registerBtnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }


    }
}