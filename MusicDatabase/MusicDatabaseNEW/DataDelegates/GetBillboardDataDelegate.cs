using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetBillboardDataDelegate : DataReaderDelegate<Billboard>
    {
        private readonly int albumID;
        private readonly DateTimeOffset startDate;
        private readonly DateTimeOffset endDate;

        public GetBillboardDataDelegate(int albumID, DateTimeOffset startDate, DateTimeOffset endDate)
           : base("Music.GetBillboard")
        {
            this.albumID = albumID;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumID);
            command.Parameters.AddWithValue("StartDate", startDate);
            command.Parameters.AddWithValue("EndDate", endDate);
        }

        public override Billboard Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Billboard(
               reader.GetInt32("BillboardID"),
               albumID,
               startDate,
               endDate);
        }
    }
}
