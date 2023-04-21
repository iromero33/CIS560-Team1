using System;

namespace MusicDatabase.Models
{
    public class Album
    {
        public int AlbumID { get; }

        public string Name { get; }

        public DateTimeOffset ReleaseDate { get; }

        internal Album(int albumId, string name, DateTimeOffset releaseDate)
        {
            AlbumID = albumId;
            Name = name;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

