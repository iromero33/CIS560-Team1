using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;
using System.Data;

namespace MusicDatabase
{
    internal class GetAlbumPeakOnBillboardDataDelegate : DataReaderDelegate<int>
    {
        private readonly int albumID;

        public GetAlbumPeakOnBillboardDataDelegate(int albumID)
           : base("Music.GetAlbumPeakOnBillboard")
        {
            this.albumID = albumID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumID);
            var p = command.Parameters.Add("BillboardPeak", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override int Translate(SqlCommand command, IDataRowReader reader)
        {
            if (command.Parameters["BillboardPeak"].Value is int answer)
            {
                return answer;
            }
            else
            {
                return 0;
            }
        }
    }
}
