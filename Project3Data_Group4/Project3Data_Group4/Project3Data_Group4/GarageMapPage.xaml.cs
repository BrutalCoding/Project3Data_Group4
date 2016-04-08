using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Diagnostics;

namespace Project3Data_Group4
{
	public partial class GarageMapPage : ContentPage
	{
		public GarageMapPage ()
		{
			GarageViewModel vm;
			InitializeComponent ();
			BindingContext = vm = new GarageViewModel();

			MyMap.MoveToRegion(
			    MapSpan.FromCenterAndRadius(
			        new Position(51.9202975795699,4.49352622032165), Distance.FromMiles(5)));

			ButtonGetGarages.Clicked += async (sender, e) => 
				{
					ButtonGetGarages.IsEnabled = false;
					await vm.GetGarageAsync();

					foreach(var item in vm.Garages)
					{
						var position = new Position (item.locationForDisplay.latitude, item.locationForDisplay.longitude);
						var pin = new Pin {
							Type = PinType.Place,
							Position = position,
							Label = item.Name,
							Address = item.Name
						};
						MyMap.Pins.Add(pin);
					}
					
				};
		}
	}
}

