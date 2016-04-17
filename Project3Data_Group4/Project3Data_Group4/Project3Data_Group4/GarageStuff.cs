using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Project3Data_Group4
{
	public class Garage
	{
	    public string DynamicDataUrl { get; set; }
	    public string StaticDataUrl { get; set; }
	    public bool LimitedAccess { get; set; }
		public LocationForDisplay locationForDisplay { get; set; }
		public DynamicData DynamicData { get; set; }
		public StaticData StaticData { get; set; }
	    public string Identifier { get; set; }
	    public string Name { get; set; }
		
		public string Address { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		
	}
	
	public class LocationForDisplay
	{
		public string coordinatesType { get; set; } 
		public float latitude { get; set; }
		public float longitude { get; set; }
	}

	public class StaticData 
	{
		public parkingFacilityStaticInformation parkingFacilityDynamicInformation { get; set; }
	}

	public class parkingFacilityStaticInformation 
	{
		public string Name { get; set; }
	}


	public class DynamicData 
	{
		public ParkingFacilityDynamicInformation parkingFacilityDynamicInformation { get; set; }
	}

	public class ParkingFacilityDynamicInformation 
	{
		public string Name { get; set; }
	}



	public class Garagelist
	{
	    public List<Garage> parkingFacilities { get; set; }
	}

	public class GarageViewModel
	{
		public ObservableCollection<Garage> Garages { get; } = new ObservableCollection<Garage>();
		
		public async Task GetGarageAsync ()
		{

			try {
				var client = new HttpClient ();
				var json = await client.GetStringAsync ("http://opendata.technolution.nl/opendata/parkingdata/v1");

				var geoCoder = new Geocoder();
				
				Garagelist Garagelist = JsonConvert.DeserializeObject<Garagelist>(json);

				
				
				foreach (Garage item in Garagelist.parkingFacilities)
				{
					try {
						var position = new Position (item.locationForDisplay.latitude, item.locationForDisplay.longitude);
						var possibleAddresses = await geoCoder.GetAddressesForPositionAsync (position);
						
						foreach (var address in possibleAddresses){
							string[] lines = address.Split(new string[] { "\n"}, StringSplitOptions.None);
							item.Address = lines[0];
							item.ZipCode = lines[1];
							if (lines.Length > 2)
								item.Country = lines[2];
						};

					} catch (Exception ex) {
						Debug.WriteLine(ex);
					}
					
					Garages.Add (item);
				}

			} catch (Exception ex) {
				Debug.WriteLine(ex);
			}
		}
	}
}