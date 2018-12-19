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
        public static string username;
        public static string password;
    public Register()
        {
            InitializeComponent();
        }

        private async void CheckRequirements_Clicked(object sender, EventArgs e)
        {
            bool isTextEmpty = string.IsNullOrEmpty(registerUsername.Text);
            bool isTextEmpty1 = string.IsNullOrEmpty(registerPassword.Text);
            bool isTextEmpty2 = string.IsNullOrEmpty(cardName.Text);
            bool isTextEmpty3 = string.IsNullOrEmpty(cardNum.Text);
            bool isTextEmpty4 = string.IsNullOrEmpty(cvs.Text);

            if (isTextEmpty || isTextEmpty1 || isTextEmpty2 || isTextEmpty3 || isTextEmpty4)
            {

            }
            else
            {
                registerBtn.IsEnabled = true;
            }
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