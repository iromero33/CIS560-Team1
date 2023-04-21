using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class FetchBillboardDataDelegate : DataReaderDelegate<Billboard>
    {
        private readonly int billboardID;

        public FetchBillboardDataDelegate(int billboardID)
           : base("Music.FetchBillboard")
        {
            this.billboardID = billboardID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("BillboardID", billboardID);
        }

        public override Billboard Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(billboardID.ToString());

            return new Billboard(billboardID,
               reader.GetInt32("AlbumID"),
               reader.GetDateTimeOffset("StartDate"),
               reader.GetDateTimeOffset("EndDate"));
        }
    }
}
