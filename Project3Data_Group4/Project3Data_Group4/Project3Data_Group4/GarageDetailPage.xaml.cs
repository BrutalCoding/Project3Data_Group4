using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace Project3Data_Group4
{
	public partial class GarageDetailPage : ContentPage
	{
		public GarageDetailPage (Garage garage)
		{
			BindingContext = garage;
			InitializeComponent ();
		}
	}
}



