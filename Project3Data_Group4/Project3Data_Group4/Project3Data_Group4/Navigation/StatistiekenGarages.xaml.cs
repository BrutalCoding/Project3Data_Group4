using System;
using System.Collections.ObjectModel;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Project3Data_Group4.Navigation
{
    public class MonthDemand
    {

        public MonthDemand(double year2010, double year2011)
        {
            this.Expense = year2010;
            this.Value = year2011;
        }
        public double Expense { get; set; }
        public double Value { get; set; }

    }
    public partial class StatistiekenGarages : ContentPage
    {
        
        public ObservableCollection<MonthDemand> Data { get; set; }
        public StatistiekenGarages()
        {
            InitializeComponent();

            Data = new ObservableCollection<MonthDemand>();

            Data.Add(new MonthDemand(42, 27));
        }
    }
}

