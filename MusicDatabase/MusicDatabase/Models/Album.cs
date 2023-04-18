using System;

namespace MusicDatabase.Models
{
    public class Album
    {
        public int AlbumID { get; }

        public int LabelID { get; }

        public string Name { get; }

        public DateTime ReleaseDate { get; }

        internal Album(int albumId, int labelId, string name, DateTime releaseDate)
        {
            AlbumID = albumId;
            LabelID = labelId;
            Name = name;
            ReleaseDate = releaseDate;
        }
    }
}

