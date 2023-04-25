using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetAlbumAppearancesOnBillboardDataDelegate : DataReaderDelegate<int>
    {
        private readonly int albumID;

        public GetAlbumAppearancesOnBillboardDataDelegate(int albumID)
           : base("Music.GetAlbumAppearancesOnBillboard")
        {
            this.albumID = albumID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumID);
        }

        public override int Translate(SqlCommand command, IDataRowReader reader)
        {
            return reader.GetInt32("AlbumAppearances");
        }
    }
}
