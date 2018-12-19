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
    public partial class Register : ContentPage
    {
        string username;
        string password;
    public Register()
        {
            InitializeComponent();
        }
        private async void Register_Clicked(object sender, EventArgs e)
        { 
            username = registerUsername.Text;
            password = registerPassword.Text;

            // Navigate to Login Page once the Registration is successful
            await DisplayAlert("Registration Successful!", "Press Continue to Login!", "Continue");
            Application.Current.MainPage = new NavigationPage(new Login());
        }
    }
}