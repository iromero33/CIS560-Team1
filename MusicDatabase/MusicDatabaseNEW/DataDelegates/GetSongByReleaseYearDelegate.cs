using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;
using System.Xml.Linq;

namespace MusicDatabase.DataDelegates
{
    internal class GetSongByReleaseYearDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        private readonly DateTimeOffset year;
        
        public GetSongByReleaseYearDelegate(DateTimeOffset year)
            : base("Music.GetSongByReleaseYear")
        {
            this.year = year;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Year", year);
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
