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
	public partial class EatIn : ContentPage
	{
        //string mainCourse1;
		public EatIn ()
		{
			InitializeComponent ();
		}

        private async void Desserts_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Desserts());
        }

        //private async void Desserts1_Clicked(object sender, EventArgs e)
        //{
        //    Application.Current.MainPage = new NavigationPage(new Desserts());

        //    //This gets the full path for the "files" directory of your app, where you have permission to read/write.
        //    string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "orderList.txt");

        //    //This creates the full file path to your "testfile.txt" file.
        //    var filePath = System.IO.Path.Combine(fileName, "orderList.txt");

        //    //Now create the file.
        //    System.IO.File.Create(fileName);



        //    File.WriteAllText(fileName, "Breakfast Burger");
        //}
    }
}