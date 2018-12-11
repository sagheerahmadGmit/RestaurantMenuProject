using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantMenuApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /*
                async void Eatin_Clicked(object sender, EventArgs e)
                {
                     await Navigation.PushAsync(new EatIn());
                }
        */
        private async void Eatin_Clicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new NavigationPage(new EatIn());
        }
    }
}
