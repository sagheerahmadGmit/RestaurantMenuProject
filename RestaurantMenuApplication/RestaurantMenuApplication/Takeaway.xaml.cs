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
	public partial class Takeaway : ContentPage
	{
        //setting up variables
        public static string takeaway = "No Takeaway";
        public static double takeawayPrice = 0;
        public Takeaway ()
		{
			InitializeComponent ();
		}
        // Method to go to next page and save order
        private async void Ordered1_Clicked(object sender, EventArgs e)
        {
            takeaway = "Fish and Chips";
            takeawayPrice = 8.50;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // Method to go to next page and save order
        private async void Ordered2_Clicked(object sender, EventArgs e)
        {
            takeaway = "Vegetarian Fried Rice";
            takeawayPrice = 9.99;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // Method to go to next page and save order
        private async void Ordered3_Clicked(object sender, EventArgs e)
        {
            takeaway = "Stir Fried Noodles";
            takeawayPrice = 9.99;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // Method to go to next page and save order
        private async void Ordered4_Clicked(object sender, EventArgs e)
        {
            takeaway = "Prawn Fried Rice";
            takeawayPrice = 12.50;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // Method to go to next page and save order
        private async void Ordered5_Clicked(object sender, EventArgs e)
        {
            takeaway = "12' Pizza - Meat Supreme";
            takeawayPrice = 12.99;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // Method to go to next page and save order
        private async void Ordered6_Clicked(object sender, EventArgs e)
        {
            takeaway = "Pilpel Falafel";
            takeawayPrice = 8.99;
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        // go back to the home page
        private void HomePage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}