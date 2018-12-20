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
        //Go to the eat in page
        private async void Eatin_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new EatIn());
        }
        //go to the takeaway page
        private async void Takeaway_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Takeaway());
        }
        // go to the desserts page
        private async void Desserts_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        //Go to the about us page
        private async void About_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new About());
        }
    }
}
