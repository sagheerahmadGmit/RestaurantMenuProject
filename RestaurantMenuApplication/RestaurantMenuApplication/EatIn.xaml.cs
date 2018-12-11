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
	public partial class EatIn : ContentPage
	{
		public EatIn ()
		{
			InitializeComponent ();
		}

        private async void Ordered_Clicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new NavigationPage(new Drinks());
        }
    }
}