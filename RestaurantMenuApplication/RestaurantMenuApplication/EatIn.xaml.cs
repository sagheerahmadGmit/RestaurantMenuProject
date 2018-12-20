using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantMenuApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EatIn : ContentPage
	{
        public static string maincourse = "Nothing";
        public static double price = 0;
        //string mainCourse1;
		public EatIn ()
		{
			InitializeComponent ();
		}

        private async void Desserts1_Clicked(object sender, EventArgs e)
        {
            maincourse = "BreakFast Burger";
            price = 15.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts2_Clicked(object sender, EventArgs e)
        {
            maincourse = "Seared Steak";
            price = 21.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts3_Clicked(object sender, EventArgs e)
        {
            maincourse = "Scotch sirloin steak";
            price = 21.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts4_Clicked(object sender, EventArgs e)
        {
            maincourse = "Wholemeal Pasta";
            price = 12.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts5_Clicked(object sender, EventArgs e)
        {
            maincourse = "Vegetarian Burger";
            price = 15.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts6_Clicked(object sender, EventArgs e)
        {
            maincourse = "Halloween themed Pasta";
            price = 24.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Desserts7_Clicked(object sender, EventArgs e)
        {
            maincourse = "Golden Chicken Steak";
            price = 18.99;
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}