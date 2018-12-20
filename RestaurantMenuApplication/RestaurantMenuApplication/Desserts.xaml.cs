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
	public partial class Desserts : ContentPage
	{
        //setting up variables
        public static string dessert = "Nothing";
        public static double dessertPrice = 0;
		public Desserts ()
		{
			InitializeComponent ();
		}
        // Method to go to next page and save order
        private async void Ordered1_Clicked(object sender, EventArgs e)
        {
            dessert = "Lemon Sponge Cake";
            dessertPrice = 4.99;
            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
        // Method to go to next page and save order
        private async void Ordered2_Clicked(object sender, EventArgs e)
        {
            dessert = "Dessert Pizza";
            dessertPrice = 12.99;
            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
        // Method to go to next page and save order
        private async void Ordered3_Clicked(object sender, EventArgs e)
        {
            dessert = "Dessert Pizza";
            dessertPrice = 9.99;
            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
        // Method to go to next page and save order
        private async void Ordered4_Clicked(object sender, EventArgs e)
        {
            dessert = "White Chocolate Cheesecake";
            dessertPrice = 4.50;
            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
        // Method to go to next page and save order
        private async void Ordered5_Clicked(object sender, EventArgs e)
        {
            dessert = "Rocky Road Brownie";
            dessertPrice = 4.99;
            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
        // Method to go to next page and save order
        private void HomePage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}