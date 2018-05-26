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
    public partial class BMICalculator : ContentPage
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        public void pickerChange(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedItem = (string)picker.SelectedItem;


            if (selectedItem.Equals("Imperial"))
            {
                weight.Text = "Pounds";
                height.Text = "inches";
            }
            if (selectedItem.Equals("Metric"))
            {
                weight.Text = "Kg";
                height.Text = "cm";
            }
        }
        public void CalcBMIButton(object sender, EventArgs e)
        {
            double h = double.Parse(txtHeight.Text);
            double w = double.Parse(txtWeight.Text);
            double resultImp;
            double resultMet;
            string description;

            if (weight.Text == "Pounds")
            {
                resultImp = (w / (h * h)) * 703.0;

                if (resultImp <= 16.5)
                {
                    description = "severely underweight";
                }
                else if (resultImp >= 16.5 && resultImp < 18.5)
                {
                    description = "underweight";
                }
                else if (resultImp >= 18.5 && resultImp < 25)
                {
                    description = "normal";
                }
                else if (resultImp >= 25 && resultImp <= 30)
                {
                    description = "overweight";
                }
                else if (resultImp > 30 && resultImp <= 35)
                {
                    description = "obese";
                }
                else if (resultImp > 35 && resultImp <= 40)
                {
                    description = "clinically obese";
                }
                else
                {
                    description = "morbidly obese";
                }

                labelResult.Text = String.Format("{0:f2} and you are {1}", resultImp,description);
            }
            else
            {
                resultMet = (w / (h * h))*10000;
                if (resultMet <= 16.5)
                {
                    description = "severely underweight";
                }
                else if (resultMet >= 16.5 && resultMet < 18.5)
                {
                    description = "underweight";
                }
                else if (resultMet >= 18.5 && resultMet < 25)
                {
                    description = "normal";
                }
                else if (resultMet >= 25 && resultMet <= 30)
                {
                    description = "overweight";
                }
                else if (resultMet > 30 && resultMet <= 35)
                {
                    description = "obese";
                }
                else if (resultMet > 35 && resultMet <= 40)
                {
                    description = "clinically obese";
                }
                else
                {
                    description = "morbidly obese";
                }
                labelResult.Text = String.Format("{0:f2} and you are {1}",resultMet,description);
            }
           
        }
    }
}