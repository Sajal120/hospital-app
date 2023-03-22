using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry4 = Microcharts.ChartEntry;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Week4 : ContentPage
    {
        public Week4()
        {
            InitializeComponent();
        }

        private void BtnCreate3_Clicked_2(object sender, EventArgs e)
        {
            List<Entry4> _entries4 = new List<Entry4>()
       {
           new Entry4(Convert.ToSingle(G1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry4(Convert.ToSingle(G2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry4(Convert.ToSingle(G3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry4(Convert.ToSingle(G4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry4(Convert.ToSingle(G5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry4(Convert.ToSingle(G6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry4(Convert.ToSingle(G7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                   new Entry4(Convert.ToSingle(G8.Text))
           {
               Label = "Day8",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                       new Entry4(Convert.ToSingle(G9.Text))
           {
               Label = "Day9",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                           new Entry4(Convert.ToSingle(G10.Text))
           {
               Label = "Day10",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                               new Entry4(Convert.ToSingle(G11.Text))
           {
               Label = "Day11",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                   new Entry4(Convert.ToSingle(G12.Text))
           {
               Label = "Day12",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                       new Entry4(Convert.ToSingle(G13.Text))
           {
               Label = "Day13",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                           new Entry4(Convert.ToSingle(G14.Text))
           {
               Label = "Day14",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G15.Text))
           {
               Label = "Day15",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G16.Text))
           {
               Label = "Day16",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry4(Convert.ToSingle(G17.Text))
           {
               Label = "Day17",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry4(Convert.ToSingle(G18.Text))
           {
               Label = "Day18",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry4(Convert.ToSingle(G19.Text))
           {
               Label = "Day19",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry4(Convert.ToSingle(G20.Text))
           {
               Label = "Day20",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry4(Convert.ToSingle(G21.Text))
           {
               Label = "Day21",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G22.Text))
           {
               Label = "Day22",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G23.Text))
           {
               Label = "Day23",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G24.Text))
           {
               Label = "Day24",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G25.Text))
           {
               Label = "Day25",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G26.Text))
           {
               Label = "Day26",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G27.Text))
           {
               Label = "Day27",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry4(Convert.ToSingle(G28.Text))
           {
               Label = "Day28",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           } };



            ChartV4.Chart = new LineChart()
            {

                Entries = _entries4,

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
            var message = new EmailMessage(EntrySubject123.Text, "", EntryEmail123.Text);
            await Email.ComposeAsync(message);

        }
    }
}

        