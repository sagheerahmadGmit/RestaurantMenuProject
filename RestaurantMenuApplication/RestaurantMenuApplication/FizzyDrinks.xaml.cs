using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantMenuApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FizzyDrinks : ContentPage
	{
        //setting up and initialising variables
        public static string drink = "";
        public static double fizzyPrice = 0;
		public FizzyDrinks ()
		{
			InitializeComponent ();
		}
        //storing values in variables and going to the next page
        private async void OrderPage1_Clicked(object sender, EventArgs e)
        {
            drink = "Coke";
            fizzyPrice = 1.99;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //storing values in variables and going to the next page
        private async void OrderPage2_Clicked(object sender, EventArgs e)
        {
            drink = "Fanta";
            fizzyPrice = 1.99;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //storing values in variables and going to the next page
        private async void OrderPage3_Clicked(object sender, EventArgs e)
        {
            drink = "Sprite";
            fizzyPrice = 1.99; 
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        private async void OrderPage4_Clicked(object sender, EventArgs e)
        {
            drink = "Irn Bru";
            fizzyPrice = 1.99;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //storing values in variables and going to the next page
        private async void OrderPage5_Clicked(object sender, EventArgs e)
        {
            drink = "Mineral Water";
            fizzyPrice = 2.50;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //storing values in variables and going to the next page
        private async void OrderPage6_Clicked(object sender, EventArgs e)
        {
            drink = "Tap Water";
            fizzyPrice = 0;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //storing values in variables and going to the next page
        private async void OrderPage7_Clicked(object sender, EventArgs e)
        {
            drink = "No Drinks";
            fizzyPrice = 0;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        // go to the home page
        private async void Home_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}