using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry6 = Microcharts.ChartEntry;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Week6 : ContentPage
    {
        public Week6()
        {
            InitializeComponent();
        }

        private void BtnCreate6_Clicked(object sender, EventArgs e)
        {
            List<Entry6> _entries6 = new List<Entry6>()
       {
           new Entry6(Convert.ToSingle(I1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry6(Convert.ToSingle(I2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry6(Convert.ToSingle(I3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry6(Convert.ToSingle(I4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry6(Convert.ToSingle(I5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry6(Convert.ToSingle(I6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry6(Convert.ToSingle(I7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                   new Entry6(Convert.ToSingle(I8.Text))
           {
               Label = "Day8",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                       new Entry6(Convert.ToSingle(I9.Text))
           {
               Label = "Day9",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                           new Entry6(Convert.ToSingle(I10.Text))
           {
               Label = "Day10",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                               new Entry6(Convert.ToSingle(I11.Text))
           {
               Label = "Day11",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                   new Entry6(Convert.ToSingle(I12.Text))
           {
               Label = "Day12",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                       new Entry6(Convert.ToSingle(I13.Text))
           {
               Label = "Day13",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                           new Entry6(Convert.ToSingle(I14.Text))
           {
               Label = "Day14",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I15.Text))
           {
               Label = "Day15",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I16.Text))
           {
               Label = "Day16",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry6(Convert.ToSingle(I17.Text))
           {
               Label = "Day17",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry6(Convert.ToSingle(I18.Text))
           {
               Label = "Day18",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry6(Convert.ToSingle(I19.Text))
           {
               Label = "Day19",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry6(Convert.ToSingle(I20.Text))
           {
               Label = "Day20",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry6(Convert.ToSingle(I21.Text))
           {
               Label = "Day21",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I22.Text))
           {
               Label = "Day22",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I23.Text))
           {
               Label = "Day23",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I24.Text))
           {
               Label = "Day24",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I25.Text))
           {
               Label = "Day25",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I26.Text))
           {
               Label = "Day26",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I27.Text))
           {
               Label = "Day27",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I28.Text))
           {
               Label = "Day28",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I29.Text))
           {
               Label = "Day29",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I30.Text))
           {
               Label = "Day30",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I31.Text))
           {
               Label = "Day31",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I32.Text))
           {
               Label = "Day32",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I33.Text))
           {
               Label = "Day33",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I34.Text))
           {
               Label = "Day34",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I35.Text))
           {
               Label = "Day35",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I36.Text))
           {
               Label = "Day36",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I37.Text))
           {
               Label = "Day37",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I38.Text))
           {
               Label = "Day38",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I39.Text))
           {
               Label = "Day39",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I40.Text))
           {
               Label = "Day40",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I41.Text))
           {
               Label = "Day41",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry6(Convert.ToSingle(I42.Text))
           {
               Label = "Day42",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           }


            };



            ChartV6.Chart = new LineChart()
            {

                Entries = _entries6,

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
            var message = new EmailMessage(EntrySubject12345.Text, "", EntryEmail12345.Text);
            await Email.ComposeAsync(message);
        }
    }
}

