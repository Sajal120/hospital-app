using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry2 = Microcharts.ChartEntry;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Week2 : ContentPage
    {
        public Week2()
        {
            InitializeComponent();
        }
        private void BtnCreate_Clicked2(object sender, EventArgs e)
        {
            List<Entry2> _entries2 = new List<Entry2>()
       {
           new Entry2(Convert.ToSingle(E1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry2(Convert.ToSingle(E2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry2(Convert.ToSingle(E3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry2(Convert.ToSingle(E4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry2(Convert.ToSingle(E5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry2(Convert.ToSingle(E6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry2(Convert.ToSingle(E7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                   new Entry2(Convert.ToSingle(E8.Text))
           {
               Label = "Day8",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                       new Entry2(Convert.ToSingle(E9.Text))
           {
               Label = "Day9",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                           new Entry2(Convert.ToSingle(E10.Text))
           {
               Label = "Day10",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                               new Entry2(Convert.ToSingle(E11.Text))
           {
               Label = "Day11",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                   new Entry2(Convert.ToSingle(E12.Text))
           {
               Label = "Day12",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                       new Entry2(Convert.ToSingle(E13.Text))
           {
               Label = "Day13",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                           new Entry2(Convert.ToSingle(E14.Text))
           {
               Label = "Day14",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           }
            };



            ChartV2.Chart = new LineChart()
            {

                Entries = _entries2,

                PointMode = PointMode.Square,
                MinValue = 0,
                MaxValue = 100,
                LabelTextSize = 18,
                Margin = 10,
                BackgroundColor = SKColor.Parse("#ffffff")
            };
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            var message = new EmailMessage(EntrySubject1.Text, "", EntryEmail1.Text);
            await Email.ComposeAsync(message);
        }
    }
}