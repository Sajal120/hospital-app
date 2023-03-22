using SQLite;
using System;
using System.Collections.Generic;
using TravelRecordApp.Model;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }
        private void Save_Clicked(object sender, EventArgs e)
        {
            Post newPost = new Post()
            {
                Temperature = tempEntry.Text
                 ,
                Bleed = BleedEntry.Text
                 ,
                BleedSpotting = BleedSpottingEntry.Text
                 ,
                MucusSensation = MucusSensationEntry.Text
                 ,
                MucusConsistency = MucusConsistencyEntry.Text
                 ,
                MucusColour = MucusColourEntry.Text
                 ,
                MucusAmount = MucusAmountEntry.Text
                 ,
                Intercourse = IntercourseEntry.Text
                 ,
                Symptoms = SymptomsEntry.Text
                 ,
                Medications = MedicationsEntry.Text,
                Experience = experienceEntry.Text


            };
           
           
            using (SQLiteConnection conn = new SQLiteConnection(App.databaseLocation))
            {
                conn.CreateTable<Post>();
                int rowsAffected = conn.Insert(newPost);

                if (rowsAffected > 0)
                {
                    
                    tempEntry.Text= string.Empty;
                    BleedEntry.Text = string.Empty;
                    BleedSpottingEntry.Text = string.Empty;
                    MucusSensationEntry.Text = string.Empty;
                    MucusConsistencyEntry.Text = string.Empty;
                    MucusColourEntry.Text = string.Empty;
                    MucusAmountEntry.Text = string.Empty;
                    IntercourseEntry.Text = string.Empty;
                    SymptomsEntry.Text = string.Empty;
                    MedicationsEntry.Text = string.Empty;
                    experienceEntry.Text = string.Empty;
                    DisplayAlert("Success", "Post saved", "Ok");
                }
                else
                    DisplayAlert("Failure", "Post was not saved, please try again", "Ok");
            }
        }
    }
}
