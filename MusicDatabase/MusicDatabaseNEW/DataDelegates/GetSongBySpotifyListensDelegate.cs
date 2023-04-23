using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;
using System.Xml.Linq;

namespace MusicDatabase.DataDelegates
{
    internal class GetSongBySpotifyListensDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        private readonly int min;
        private readonly int max;

        public GetSongBySpotifyListensDelegate(int min, int max)
            : base("Music.GetSongBySpotifyListens")
        {
            this.min = min;
            this.max = max;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SpotifyListensMin", min);
            command.Parameters.AddWithValue("SpotifyListensMax", max);
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
