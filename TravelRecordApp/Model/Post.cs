using System;
using SQLite;

namespace TravelRecordApp.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }
        [MaxLength(250)]
        public string Temperature { get; set; }
        [MaxLength(250)]
        public string Bleed { get; set; }
        [MaxLength(250)]
        public string BleedSpotting { get; set; }
        [MaxLength(250)]
        public string MucusSensation { get; set; }
        [MaxLength(250)]
        public string MucusConsistency { get; set; }
        [MaxLength(250)]
        public string MucusColour { get; set; }
        [MaxLength(250)]
        public string MucusAmount { get; set; }
        [MaxLength(250)]
        public string Intercourse { get; set; }
        [MaxLength(250)]
        public string Symptoms { get; set; }
        [MaxLength(250)]
        public string Medications { get; set; }

    }
}
