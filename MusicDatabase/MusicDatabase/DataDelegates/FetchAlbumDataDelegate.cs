using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class FetchAlbumDataDelegate : DataReaderDelegate<Album>
    {
        private readonly int albumID;

        public FetchAlbumDataDelegate(int albumID)
           : base("Music.FetchAlbum")
        {
            this.albumID = albumID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumID);
        }

        public override Album Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(albumID.ToString());

            return new Album(albumID,
               reader.GetString("Name"),
               reader.GetDateTimeOffset("ReleaseDate"));
        }
    }
}
