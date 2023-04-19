using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using DataAccess;
using MusicDatabase.Models;

namespace MusicDatabase
{
    internal class CreateSongDataDelegate : NonQueryDataDelegate<Song>
    {
        public readonly string title;
        public readonly int artistID;
        private readonly int albumID;
        private readonly int genreID;
        private readonly int spotifyID;

        public CreateSongDataDelegate(string title, int artistID, int albumID, int genreID, int spotifyID)
           : base("Music.CreateSong")
        {
            this.title = title;
            this.artistID = artistID;
            this.albumID = albumID;
            this.genreID = genreID;
            this.spotifyID = spotifyID;
    }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Title", title);
            command.Parameters.AddWithValue("ArtistID", artistID);
            command.Parameters.AddWithValue("AlbumID", albumID);
            command.Parameters.AddWithValue("GenreID", genreID);
            command.Parameters.AddWithValue("SpotifyID", spotifyID);

            var p = command.Parameters.Add("SongID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Song Translate(SqlCommand command)
        {
            return new Song((int)command.Parameters["SongID"].Value, title, artistID, albumID, genreID, spotifyID);
        }
    }
}
