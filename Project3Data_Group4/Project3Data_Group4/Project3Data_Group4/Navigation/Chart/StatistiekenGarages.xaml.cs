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

        public StatistiekenGarages()
        {
            InitializeComponent();
            if (!(Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS))
            {
                Chart.Series[0].AnimationDuration = 4;
            }
        }
    }
}

