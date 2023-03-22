using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry5 = Microcharts.ChartEntry;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Week5 : ContentPage
    {
        public Week5()
        {
            InitializeComponent();
        }

               private void BtnCreate5_Clicked(object sender, EventArgs e)
        {
            List<Entry5> _entries5 = new List<Entry5>()
       {
           new Entry5(Convert.ToSingle(H1.Text))
           {
              Label = "Day1",
                 ValueLabel = "37.5",
                Color = SKColor.Parse("#ff0000")
           },
           new Entry5(Convert.ToSingle(H2.Text))
           {
              Label = "Day2",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#0000FF")
           },
           new Entry5(Convert.ToSingle(H3.Text))
           {
               Label = "Day3",
                ValueLabel = "37.5",
                Color = SKColor.Parse("#00ff00")

       },
            new Entry5(Convert.ToSingle(H4.Text))
           {
               Label = "Day4",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
             new Entry5(Convert.ToSingle(H5.Text))
           {
               Label = "Day5",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
              new Entry5(Convert.ToSingle(H6.Text))
           {
               Label = "Day6",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
               new Entry5(Convert.ToSingle(H7.Text))
           {
               Label = "Day7",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                   new Entry5(Convert.ToSingle(H8.Text))
           {
               Label = "Day8",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                       new Entry5(Convert.ToSingle(H9.Text))
           {
               Label = "Day9",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                           new Entry5(Convert.ToSingle(H10.Text))
           {
               Label = "Day10",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },

                               new Entry5(Convert.ToSingle(H11.Text))
           {
               Label = "Day11",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                   new Entry5(Convert.ToSingle(H12.Text))
           {
               Label = "Day12",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                       new Entry5(Convert.ToSingle(H13.Text))
           {
               Label = "Day13",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
        },
                                           new Entry5(Convert.ToSingle(H14.Text))
           {
               Label = "Day14",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H15.Text))
           {
               Label = "Day15",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H16.Text))
           {
               Label = "Day16",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry5(Convert.ToSingle(H17.Text))
           {
               Label = "Day17",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry5(Convert.ToSingle(H18.Text))
           {
               Label = "Day18",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry5(Convert.ToSingle(H19.Text))
           {
               Label = "Day19",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry5(Convert.ToSingle(H20.Text))
           {
               Label = "Day20",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },new Entry5(Convert.ToSingle(H21.Text))
           {
               Label = "Day21",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H22.Text))
           {
               Label = "Day22",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H23.Text))
           {
               Label = "Day23",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H24.Text))
           {
               Label = "Day24",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H25.Text))
           {
               Label = "Day25",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H26.Text))
           {
               Label = "Day26",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H27.Text))
           {
               Label = "Day27",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H28.Text))
           {
               Label = "Day28",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H29.Text))
           {
               Label = "Day29",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H30.Text))
           {
               Label = "Day30",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H31.Text))
           {
               Label = "Day31",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H32.Text))
           {
               Label = "Day32",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H33.Text))
           {
               Label = "Day33",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H34.Text))
           {
               Label = "Day34",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },
                                           new Entry5(Convert.ToSingle(H35.Text))
           {
               Label = "Day35",
               ValueLabel = "37.5",
               Color = SKColor.Parse("#FFC0CB")
                                           },


            };



            ChartV5.Chart = new LineChart()
            {

                Entries = _entries5,

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
            var message = new EmailMessage(EntrySubject1234.Text, "", EntryEmail1234.Text);
            await Email.ComposeAsync(message);
        }
    }
}

