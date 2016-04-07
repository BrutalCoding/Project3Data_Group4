using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project3Data_Group4
{
	public partial class GaragePage : ContentPage
	{
		public GaragePage ()
		{
			GarageViewModel vm;
			InitializeComponent ();
			BindingContext = vm = new GarageViewModel();

			ButtonGetGarages.Clicked += async (sender, e) => 
				{
					ButtonGetGarages.IsEnabled = false;
					await vm.GetGarageAsync();
	
//					ButtonGetGarages.IsEnabled = true;
				};
			GaragesList.ItemTapped += (sender, e) => {
				Navigation.PushAsync (new GarageDetailPage ());
			};	
		}
	}
}

