#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project3Data_Group4.Navigation.Chart;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Project3Data_Group4
{
    public class ViewModel
    {
        private int aantalGarages = 1;
        private int aantalRETHaltes = 1;
        private bool done = false;
        public class Garagelist
        {
            public List<Garage> parkingFacilities { get; set; }
        }
        public ObservableCollection<Garage> Garages { get; } = new ObservableCollection<Garage>();
        public async Task GetGarageAsync()
        {
            LoadData();
            var client = new HttpClient();
            var json = await client.GetStringAsync("http://opendata.technolution.nl/opendata/parkingdata/v1");
            Project3Data_Group4.Garagelist Garagelist = JsonConvert.DeserializeObject<Project3Data_Group4.Garagelist>(json);
            aantalGarages = Garagelist.parkingFacilities.Count;
            done = true;
        }
        public ObservableCollection<Model> PieSeriesData { get; set; }

        public ObservableCollection<Model> PieData { get; set; }

        public ViewModel()
        {
            LoadPieChart();
        }

        private void LoadData()
        {
            PieSeriesData = new ObservableCollection<Model>
            {
                new Model("Aantal garages", aantalGarages),
                new Model("Aantal RET haltes", aantalRETHaltes)
            };

            PieData = new ObservableCollection<Model>
            {
                new Model(new DateTime(2016, 4, 17), 100)
            };
        }
        public async void LoadPieChart()
        {
            await GetGarageAsync();
        }
    }
}

        
