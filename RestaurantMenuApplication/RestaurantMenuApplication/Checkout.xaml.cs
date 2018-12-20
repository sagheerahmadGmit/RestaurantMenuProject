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
	public partial class Checkout : ContentPage
	{
        public static string list;
		public Checkout ()
		{
			InitializeComponent ();
            //Outpting all the meals and drinks the user has chosen
            mainCourse.Text = "The Main Course you chose is: " + EatIn.maincourse;
            dessert.Text = "The Dessert you ordered is: " + Desserts.dessert;
            drink.Text = "The Drink you ordered is: " + Drinks.drink + FizzyDrinks.drink;
            takeaway.Text = "For your takeaway you have ordered: " + Takeaway.takeaway;
            //outputting the total bill
            total.Text = "Your total bill is: €" + (EatIn.price + Desserts.dessertPrice + Drinks.drinkPrice + FizzyDrinks.fizzyPrice + Takeaway.takeawayPrice);
        }
        private async void Confirm_Clicked(object sender, EventArgs e)
        {
            //display alert to confirm
            await DisplayAlert("Payment Successful!", "The Order has been confirmed and will be out to you shortly!", "Home");
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }// Confirm Payment

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            //display alert to cancel
            await DisplayAlert("Payment Cancelled!", "The Order was cancelled!", "Home");
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }//Confrim cancellation
    }
}