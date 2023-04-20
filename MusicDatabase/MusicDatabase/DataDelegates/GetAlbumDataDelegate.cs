using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetAlbumDataDelegate : DataReaderDelegate<Album>
    {
        private readonly string name;

        public GetAlbumDataDelegate(string name)
           : base("Music.GetAlbum")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Album Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Album(
               reader.GetInt32("AlbumID"),
               name,
               reader.GetDateTimeOffset("ReleaseDate"));
        }
    }
}
