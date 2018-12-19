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
        string loginUsername;
        string loginPassword;
		public Login ()
		{
			InitializeComponent ();
		}

        private async void Login_Clicked(object sender, EventArgs e)
        {

           // loginUsername = username;
           // loginPassword = password;

            if (entryUsername.Text == "Sagheer" && entryPassword.Text == "1234")
            {
                await DisplayAlert("Login Successful!", "You Have Successfully paid!", "Home Page");
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                await DisplayAlert("Login failed!", "Login unsuccessful!", "Retry");
            }
        }
        private void Register_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Register());
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Payment Cancelled!", "The Login was Interupted!", "Home");
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}