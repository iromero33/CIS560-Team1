using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetSongDataDelegate : DataReaderDelegate<Song>
    {
        private readonly string title;
        private readonly int albumID;

        public GetSongDataDelegate(string title, int albumID)
           : base("Music.GetSong")
        {
            this.title = title;
            this.albumID = albumID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Title", title);
            command.Parameters.AddWithValue("AlbumID", albumID);
        }

        public override Song Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Song(
               reader.GetInt32("SongID"),
               title,
               reader.GetInt32("ArtistID"),
               albumID,
               reader.GetInt32("GenreID"),
               reader.GetInt32("SpotifyID"));
        }
    }
}
