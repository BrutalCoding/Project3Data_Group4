using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Diagnostics;


namespace Project3Data_Group4
{
	public partial class GaragePage : ContentPage
	{
		public GaragePage ()
		{
			GarageViewModel vm;
			InitializeComponent();
			BindingContext = vm = new GarageViewModel();

			
//			Get list items
			ButtonGetGaragesList.Clicked += async (sender, e) => 
			{
				ButtonGetGaragesList.IsEnabled = false;
				await vm.GetGarageAsync();
	
				ButtonGetGaragesList.IsEnabled = true;
			};


//			Get map pins
			MyMap.MoveToRegion(
			    MapSpan.FromCenterAndRadius(
			        new Position(51.9202975795699,4.49352622032165), Distance.FromMiles(5)));

			ButtonGetGaragesMap.Clicked += async (sender, e) => 
				{
					ButtonGetGaragesMap.IsEnabled = false;
					await vm.GetGarageAsync();

					foreach(var item in vm.Garages)
					{
                        var position = new Position(item.locationForDisplay.latitude, item.locationForDisplay.longitude);
                        var pin = new Pin
                        {
                            Type = PinType.Place,
                            Position = position,
                            Label = item.Name,
                            Address = item.Name
                        };
                        MyMap.Pins.Add(pin);
					}
					
				};


			GaragesList.ItemTapped += (sender, e) => {
				var garage = (GaragesList.SelectedItem as Garage);
				var garagePosition = new Position(garage.locationForDisplay.latitude,garage.locationForDisplay.longitude);

				MyMap.MoveToRegion(
					MapSpan.FromCenterAndRadius(
						garagePosition, Distance.FromMiles(.1f)));
			};	
		} 
		public void GetRoute (object sender, EventArgs e) {
		    var mi = ((MenuItem)sender);
		    //DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
		}
	}
}

