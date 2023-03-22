using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    public partial class MapPage : ContentPage
    {
        

        public MapPage()
        {
            InitializeComponent();
        }

        private void wk1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week1());
        }

        private void wk2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week2());
        }

        private void wk3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week3());
        }

        private void wk4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week4());
        }

        private void wk5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week5());
        }

        private void wk6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Week6());
        }
    }
}
