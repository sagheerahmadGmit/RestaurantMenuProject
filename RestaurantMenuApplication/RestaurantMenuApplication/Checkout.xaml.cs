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

            foodList.Text = "The Main Course you chose is: " + EatIn.maincourse + 
                "The Dessert you chose is " + Desserts.dessert; 

		}
	}
}