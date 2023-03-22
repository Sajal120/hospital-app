using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry3 = Microcharts.ChartEntry;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Week3 : ContentPage
    {
        public Week3()
        {
            InitializeComponent();
        }
        private void BtnCreate3_Clicked(object sender, EventArgs e)
        {
            List<Entry3> _entries3 = new List<Entry3>()
       {
           new Entry3(Convert.ToSingle(F1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry3(Convert.ToSingle(F2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry3(Convert.ToSingle(F3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry3(Convert.ToSingle(F4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry3(Convert.ToSingle(F5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry3(Convert.ToSingle(F6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry3(Convert.ToSingle(F7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                   new Entry3(Convert.ToSingle(F8.Text))
           {
               Label = "Day8",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                       new Entry3(Convert.ToSingle(F9.Text))
           {
               Label = "Day9",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                           new Entry3(Convert.ToSingle(F10.Text))
           {
               Label = "Day10",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                               new Entry3(Convert.ToSingle(F11.Text))
           {
               Label = "Day11",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                   new Entry3(Convert.ToSingle(F12.Text))
           {
               Label = "Day12",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                       new Entry3(Convert.ToSingle(F13.Text))
           {
               Label = "Day13",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                           new Entry3(Convert.ToSingle(F14.Text))
           {
               Label = "Day14",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry3(Convert.ToSingle(F15.Text))
           {
               Label = "Day15",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry3(Convert.ToSingle(F16.Text))
           {
               Label = "Day16",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry3(Convert.ToSingle(F17.Text))
           {
               Label = "Day17",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry3(Convert.ToSingle(F18.Text))
           {
               Label = "Day18",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry3(Convert.ToSingle(F19.Text))
           {
               Label = "Day19",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry3(Convert.ToSingle(F20.Text))
           {
               Label = "Day20",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry3(Convert.ToSingle(F21.Text))
           {
               Label = "Day21",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           }
            };



            ChartV3.Chart = new LineChart()
            {

                Entries = _entries3,

                PointMode = PointMode.Square,
                MinValue = 0,
                MaxValue = 100,
                LabelTextSize = 18,
                Margin = 10,
                BackgroundColor = SKColor.Parse("#ffffff")
            };
        }

     
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var message = new EmailMessage(EntrySubject12.Text, "", EntryEmail12.Text);
            await Email.ComposeAsync(message);
        }
    }
}