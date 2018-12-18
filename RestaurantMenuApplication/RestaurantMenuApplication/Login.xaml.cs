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
	public partial class Login : ContentPage
	{
        String username;
		public Login ()
		{
			InitializeComponent ();
		}

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (entryUsername.Text == "Sagheer" && entryPassword.Text == "1234")
            {
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
    }
}