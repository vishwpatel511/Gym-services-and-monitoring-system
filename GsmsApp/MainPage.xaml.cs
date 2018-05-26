using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GsmsApp
{
	public partial class MainPage : ContentPage
	{  

        public MainPage()
		{
			InitializeComponent();
        }

        public async void pickerChange(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedItem = (string)picker.SelectedItem;
            

            if (selectedItem.Equals("Member"))
            {
                    await Navigation.PushAsync(new LoginMember());
            }

            else if (selectedItem.Equals("Consultant"))
            {
                await Navigation.PushAsync(new LoginConsultant());
            }

            else
            {
                    await Navigation.PushAsync(new LoginAdmin());
            }
        }

    }
}




      
