using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Project3Data_Group4
{
	public partial class MasterMenu : MasterDetailPage
	{
		public class ListItem{
			public string Item {get; set;}
		}
		ObservableCollection<ListItem> items = new ObservableCollection<ListItem>();
		public MasterMenu ()
		{
			InitializeComponent ();

			items.Add(new ListItem{ Item="Rob Finnerty"});
			items.Add(new ListItem{ Item="Bill Wrestler"});
			items.Add(new ListItem{ Item="Dr. Geri-Beth Hooper"});
			items.Add(new ListItem{ Item="Dr. Keith Joyce-Purdy"});
			items.Add(new ListItem{ Item="Sheri Spruce"});
			items.Add(new ListItem{ Item="Burt Indybrick"});

			ListItems.ItemsSource = items;

			ListItems.ItemTapped += OnItemSelected;
		}
		async void OnItemSelected (object sender, EventArgs e)
		{
			//Debug Test
//			DisplayAlert ("Title","hi","Close");

			//to anohter xaml page
			await Navigation.PushAsync (new Second());
		}
	}
}

