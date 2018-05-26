﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GsmsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginAdmin : ContentPage
	{
		public LoginAdmin ()
		{
			InitializeComponent ();
		}
        private async void loginBtnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminHomePage());
        }
    }
}