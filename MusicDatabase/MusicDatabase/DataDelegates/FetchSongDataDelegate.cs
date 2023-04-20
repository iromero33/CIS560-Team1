using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class FetchSongDataDelegate : DataReaderDelegate<Song>
    {
        private readonly int songId;

        public FetchSongDataDelegate(int songId)
           : base("Music.FetchSong")
        {
            this.songId = songId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SongID", songId);
        }

        public override Song Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(songId.ToString());

            return new Song(songId,
               reader.GetString("Title"),
               reader.GetInt32("ArtistID"),
               reader.GetInt32("AlbumID"),
               reader.GetInt32("GenreID"),
               reader.GetInt32("SpotifyListens"));
        }
    }
}
