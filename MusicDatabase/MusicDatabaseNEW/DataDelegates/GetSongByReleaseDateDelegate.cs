using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;
using System.Xml.Linq;

namespace MusicDatabase.DataDelegates
{
    internal class GetSongByReleaseDateDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        private readonly DateTimeOffset date;
        
        public GetSongByReleaseDateDelegate(DateTimeOffset date)
            : base("Music.GetSongByReleaseDate")
        {
            this.date = date;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReleaseDate", date);
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
