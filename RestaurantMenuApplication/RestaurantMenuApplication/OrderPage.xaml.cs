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
	public partial class OrderPage : ContentPage
	{
		public OrderPage ()
		{
			InitializeComponent ();
		}
        // go to the login page
        private void Login_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        //go back to the homepage and restart
        private void HomePage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        // go to takeaway page and add it to the order
        private void Takeaway_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Takeaway());
        }
        //private void ShowOrder_Clicked(object sender, EventArgs e)
        //{
        //    string text = File.ReadAllText("orderList.txt");
        //    mainCourse.Text
        //}
    }
}