using System;

namespace MusicDatabase.Models
{
    public class RecordLabel
    {
        public int LabelID { get; }

        public string Name { get; }

        public string City { get; }

        public string Country { get; }

        internal RecordLabel(int labelId, string name, string city, string country)
        {
            LabelID = labelId;
            Name = name;
            City = city;
            Country = country;
        }
    }
}

