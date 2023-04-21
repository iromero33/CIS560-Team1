using System;
using System.Xml.Linq;

namespace MusicDatabase.Models
{
    public class Song
    {
        public int SongID { get; }

        public string Title { get; }

        public int ArtistID { get;  }

        public int AlbumID { get; }

        public int GenreID { get; }

        public int SpotifyListens { get; }

        internal Song(int songId, string title, int artistId, int albumId, int genreId, int spotifyListens)
        {
            SongID = songId;
            Title = title;
            ArtistID = artistId;
            GenreID = genreId;
            SpotifyListens = spotifyListens;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}

