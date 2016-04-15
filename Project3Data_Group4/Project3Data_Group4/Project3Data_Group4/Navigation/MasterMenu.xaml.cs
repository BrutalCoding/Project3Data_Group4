using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Project3Data_Group4.Navigation
{
    public partial class MasterMenu : MasterDetailPage
    {
        public class ItemsInMenu
        {
            public string LijstItemNaam { get; set; }
        }
        private ObservableCollection<ItemsInMenu> MenuItems = new ObservableCollection<ItemsInMenu>();
        private ObservableCollection<ItemsInMenu> DetailItems = new ObservableCollection<ItemsInMenu>();
        public MasterMenu()
        {
            InitializeComponent();
            NavigatieMenu();
            NavigatieDetails();
        }

        private void NavigatieMenu()
        {
            MenuItems.Add(new ItemsInMenu { LijstItemNaam = "Toon map" });
            MenuItems.Add(new ItemsInMenu { LijstItemNaam = "Toon RET haltes" });
            MenuItems.Add(new ItemsInMenu { LijstItemNaam = "Over ons" });
            MasterMenuNavMaster.ItemsSource = MenuItems;
            MasterMenuNavMaster.ItemSelected += MasterMenuNavMasterOnItemSelected;
        }

        private void MasterMenuNavMasterOnItemSelected(object sender, SelectedItemChangedEventArgs selectedItemChangedEventArgs)
        {
            var gekozenOptie = (ItemsInMenu) selectedItemChangedEventArgs.SelectedItem;
            switch (gekozenOptie.LijstItemNaam)
            {
                case "Toon map":
                    this.Detail = new TabbedPage { Children = {new GaragePage(), new Tabs.StatistiekenGarages()}};
                    break;

                default:
                    DisplayAlert("Sorry", "Dit is nog niet beschikbaar.", "Begrepen");
                    break;
            }
        }

        private void NavigatieDetails()
        {
            DetailItems.Add(new ItemsInMenu { LijstItemNaam = "15 april 2016: App beschikbaar" });
            DetailItems.Add(new ItemsInMenu { LijstItemNaam = "14 april 2016: Garages map toegevoegd" });
            MasterMenuNavDetail.ItemsSource = DetailItems;
        }
    }
}
