using System;
using System.Collections.Generic;
using SQLite;
using TravelRecordApp.Model;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class TravelDetailsPage : ContentPage
    {
        Post selectedPost;
        public TravelDetailsPage(Post selectedPost)
        {
            InitializeComponent();

            this.selectedPost = selectedPost;
            tempEntry.Text = selectedPost.Temperature;
            BleedEntry.Text = selectedPost.Bleed;
            BleedSpottingEntry.Text = selectedPost.BleedSpotting;
            MucusSensationEntry.Text = selectedPost.MucusSensation;
            MucusConsistencyEntry.Text = selectedPost.MucusConsistency;
            MucusColourEntry.Text = selectedPost.MucusColour;
            MucusAmountEntry.Text = selectedPost.MucusAmount;
            IntercourseEntry.Text = selectedPost.Intercourse;
            SymptomsEntry.Text = selectedPost.Symptoms;
            MedicationsEntry.Text = selectedPost.Medications;
            experienceEntry.Text = selectedPost.Experience;
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databaseLocation))
            {
                conn.CreateTable<Post>();

                int affectedRows = conn.Delete(selectedPost);

                if (affectedRows > 0)
                {
                    DisplayAlert("Success", "Post deleted", "Ok");
                }
                else
                    DisplayAlert("Failure", "Post was not deleted, please try again", "Ok");
            }
        
        }

        void Update_Clicked(System.Object sender, System.EventArgs e)
        {
            selectedPost.Bleed = BleedEntry.Text;
            selectedPost.BleedSpotting = BleedSpottingEntry.Text;
            selectedPost.BleedSpotting = BleedSpottingEntry.Text;
            selectedPost.MucusConsistency = MucusConsistencyEntry.Text;
            selectedPost.MucusColour = MucusColourEntry.Text;
            selectedPost.MucusAmount = MucusAmountEntry.Text;
            selectedPost.Intercourse = IntercourseEntry.Text;
            selectedPost.Symptoms = SymptomsEntry.Text;
            selectedPost.Medications = MedicationsEntry.Text;
            selectedPost.Experience = experienceEntry.Text;
            using (SQLiteConnection conn = new SQLiteConnection(App.databaseLocation))
            {
                conn.CreateTable<Post>();

                int affectedRows = conn.Update(selectedPost);

                if (affectedRows > 0)
                {
                         DisplayAlert("Success", "Post updated", "Ok");
                }
                else
                    DisplayAlert("Failure", "Post was not updated, please try again", "Ok");
            }
        }
        }
    }

