﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestaurantMenuApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Drinks : ContentPage
	{
        public static string drink = "";
        public static double drinkPrice = 0.00;
		public Drinks ()
		{
			InitializeComponent ();
		}
        //Setting up the variables and storing values in them
        private async void OrderPage1_Clicked(object sender, EventArgs e)
        {
            drink = "Red Wine";
            drinkPrice = 28.99;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage2_Clicked(object sender, EventArgs e)
        {
            drink = "White Wine";
            drinkPrice = 32.99;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage3_Clicked(object sender, EventArgs e)
        {
            drink = "White Wine";
            drinkPrice = 25;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage4_Clicked(object sender, EventArgs e)
        {
            drink = "Red Wine";
            drinkPrice = 30;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage5_Clicked(object sender, EventArgs e)
        {
            drink = "Mineral Water";
            drinkPrice = 2.50;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage6_Clicked(object sender, EventArgs e)
        {
            drink = "Tap Water";
            drinkPrice = 0;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them
        private async void OrderPage7_Clicked(object sender, EventArgs e)
        {
            drink = "No Drinks";
            drinkPrice = 0;
            Application.Current.MainPage = new NavigationPage(new OrderPage());
        }
        //Setting up the variables and storing values in them

        private async void FizzyDrinks_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new FizzyDrinks());
        }
        //Go back to the homepage
        private async void Home_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}