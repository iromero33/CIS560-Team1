using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;
using System.Data;

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

            var p = command.Parameters.Add("AlbumAppearances", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override int Translate(SqlCommand command, IDataRowReader reader)
        {
            if (command.Parameters["AlbumAppearances"].Value is int answer)
            {
                return answer;
            } else
            {
                return 0;
            }
            
        }
    }
}
