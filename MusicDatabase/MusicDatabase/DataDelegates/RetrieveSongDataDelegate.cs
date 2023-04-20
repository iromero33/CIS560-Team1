using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;

namespace MusicDatabase
{
    internal class RetrieveSongDataDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        public RetrieveSongDataDelegate()
            : base("Music.RetrieveSong")
        {
        }

        public override IReadOnlyList<Song> Translate(SqlCommand command, IDataRowReader reader)
        {
            var songs = new List<Song>();

            while (reader.Read())
            {
                songs.Add(new Song(
                    reader.GetInt32("SongID"),
                    reader.GetString("Title"),
                    reader.GetInt32("ArtistID"),
                    reader.GetInt32("AlbumID"),
                    reader.GetInt32("GenreID"),
                    reader.GetInt32("SpotifyListens")));
            }

            return songs;
        }
    }
}
