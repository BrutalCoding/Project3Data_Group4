using System;
using System.Collections.ObjectModel;
using Project3Data_Group4.Navigation.Chart;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Project3Data_Group4.Navigation
{
    public partial class StatistiekenGarages : ContentPage
    {
        public ObservableCollection<Model> PieSeriesData { get; set; }
        public ObservableCollection<Model> PieData { get; set; }

        public StatistiekenGarages()
        {
            InitializeComponent();

            PieData = new ObservableCollection<Model>
            {
                new Model(new DateTime(2014, 1, 1), 48),
                new Model(new DateTime(2014, 2, 1), 38),
                new Model(new DateTime(2014, 3, 1), 28),
                new Model(new DateTime(2014, 4, 1), 33),
                new Model(new DateTime(2014, 5, 1), 25),
                new Model(new DateTime(2014, 6, 1), 34)
            };

            PieSeriesData = new ObservableCollection<Model>
            {
                new Model("Other personal", 94658),
                new Model("Medical care", 9090),
                new Model("Housing", 2577),
                new Model("Transportation", 473),
                new Model("Education", 120),
                new Model("Electronics", 70),
           };

            if (!(Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS))
            {
                Chart.Series[0].AnimationDuration = 2;
            }
        }
    }
}

