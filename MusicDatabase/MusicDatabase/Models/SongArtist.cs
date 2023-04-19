using System;

namespace MusicDatabase.Models
{
    public class SongArtist
    {
        public int ArtistId { get; }

        public int SongId { get; }

        internal SongArtist(int artistId, int songId)
        {
            ArtistId = artistId;
            SongId = songId;
        }
    }
}

