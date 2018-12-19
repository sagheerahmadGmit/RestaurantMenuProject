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
        private async void Eatin_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new EatIn());
        }
        private async void Takeaway_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Takeaway());
        }
        private async void Desserts_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }

        private async void About_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new About());
        }
    }
}
