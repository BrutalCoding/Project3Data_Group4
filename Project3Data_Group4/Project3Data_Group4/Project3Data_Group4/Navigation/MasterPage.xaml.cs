using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project3Data_Group4
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Park Capacity",
				IconSource = "MenuIcon.png",
				TargetType = typeof(ParkCapacity)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Garage on Map",
				IconSource = "MenuIcon.png",
				TargetType = typeof(GaragePage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Credits",
				IconSource = "MenuIcon.png",
				TargetType = typeof(Second)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
