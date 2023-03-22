using Microcharts;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace TravelRecordApp
{

    public partial class Week1 : ContentPage
    {
        public Week1()
        {
            InitializeComponent();
        }
        private void BtnCreate_Clicked(object sender, EventArgs e)
        {
            List<Entry> _entries = new List<Entry>()
       {
           new Entry(Convert.ToSingle(D1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry(Convert.ToSingle(D2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry(Convert.ToSingle(D3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry(Convert.ToSingle(D4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry(Convert.ToSingle(D5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry(Convert.ToSingle(D6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry(Convert.ToSingle(D7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        }

            };
            ChartV.Chart = new LineChart()
            {

                Entries = _entries,

                PointMode = PointMode.Square,
                MinValue = 0,
                MaxValue = 100,
                LabelTextSize = 18,
                Margin = 10,
                BackgroundColor = SKColor.Parse("#ffffff")
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var message = new EmailMessage(EntrySubject.Text, "", EntryEmail.Text);
            await Email.ComposeAsync(message);
        }
    }
    }