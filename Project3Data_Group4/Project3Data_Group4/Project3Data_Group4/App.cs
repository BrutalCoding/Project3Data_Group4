﻿using System;
using Xamarin.Forms;

namespace Project3Data_Group4
{
    public class App : Application
    {
        public App()
        {
//			Master Menu
			MainPage = new Project3Data_Group4.Menu();

//			MainPage = new NavigationPage(new Menu());

			// page with all garages in map
			// MainPage = new NavigationPage(new GarageMapPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}