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

        private void Login_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        private void HomePage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
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