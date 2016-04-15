using System;
using Xamarin.Forms;

namespace Project3Data_Group4
{
    public class App : Application
    {
		public App()
        {
//			Master Menu
			MainPage = new Navigation.MasterMenu();
//			 page with all garages in map
//			MainPage = new NavigationPage(new GarageMapPage());
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