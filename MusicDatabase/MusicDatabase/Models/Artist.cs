using System;

namespace MusicDatabase.Models
{
    public class Artist
    {
        public int ArtistID { get; }

        public int SongID { get; }

        public string Name { get; }

        public string StreamingService { get; }

        internal Artist(int artistId, int songId, string name, string streamingService)
        {
            ArtistID = artistId;
            SongID = songId;
            Name = name;
            StreamingService = streamingService;
        }
    }
}

