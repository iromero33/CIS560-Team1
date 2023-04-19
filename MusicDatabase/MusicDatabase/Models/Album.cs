using System;

namespace MusicDatabase.Models
{
    public class Album
    {
        public int AlbumID { get; }

        public string Name { get; }

        public DateTime ReleaseDate { get; }

        internal Album(int albumId, string name, DateTime releaseDate)
        {
            AlbumID = albumId;
            Name = name;
            ReleaseDate = releaseDate;
        }
    }
}

