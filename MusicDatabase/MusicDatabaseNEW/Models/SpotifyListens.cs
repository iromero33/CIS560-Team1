using System;

namespace MusicDatabase.Models
{
    public class SpotifyListens
    {
        public int SpotifyID { get; }

        public int Listens { get; }

        public int SongID { get; }

        internal SpotifyListens(int spotifyId, int listens, int songId)
        {
            SpotifyID = spotifyId;
            Listens = listens;
            SongID = songId;
        }
    }
}

