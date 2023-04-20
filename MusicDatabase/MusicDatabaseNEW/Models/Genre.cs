using System;

namespace MusicDatabase.Models
{
    public class Genre
    {
        public int GenreID { get; }

        public string Name { get; }

        internal Genre(int genreId, string name)
        {
            GenreID = genreId;
            Name = name;
        }
    }
}

