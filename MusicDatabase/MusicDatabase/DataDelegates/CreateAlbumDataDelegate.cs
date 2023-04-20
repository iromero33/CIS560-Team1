using MusicDatabase.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MusicDatabase.DataDelegates
{
    internal class CreateAlbumDataDelegate : NonQueryDataDelegate<Album>
    {
        public readonly string name;
        public readonly DateTimeOffset releaseDate;

        public CreateAlbumDataDelegate(string name, DateTimeOffset release)
           : base("Music.CreateAlbum")
        {
            this.name = name;
            this.releaseDate = release;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("ReleaseDate", releaseDate);

            var p = command.Parameters.Add("AlbumID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Album Translate(SqlCommand command)
        {
            return new Album((int)command.Parameters["AlbumID"].Value, name, releaseDate);
        }
    }
}
