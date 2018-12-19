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
	public partial class Drinks : ContentPage
	{
		public Drinks ()
		{
			InitializeComponent ();
		}

        private async void OrderPage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }

        private async void FizzyDrinks_Clicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new NavigationPage(new FizzyDrinks());
        }
    }
}