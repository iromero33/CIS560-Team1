using System;

namespace MusicDatabase.Models
{
    public class Artist
    {
        public int ArtistID { get; }

        //public int SongID { get; }

        public string Name { get; }

        internal Artist(int artistId/*, int songId*/, string name)
        {
            ArtistID = artistId;
            //SongID = songId;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

