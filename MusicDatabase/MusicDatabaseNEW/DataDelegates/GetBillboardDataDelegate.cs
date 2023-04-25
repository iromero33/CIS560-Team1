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
        private readonly DateTimeOffset date;
        private readonly int rank;

        public GetBillboardDataDelegate(int albumID, DateTimeOffset date, int rank)
           : base("Music.GetBillboard")
        {
            this.albumID = albumID;
            this.date = date;
            this.rank = rank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumID);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Rank", rank);
        }

        public override Billboard Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Billboard(
               reader.GetInt32("BillboardID"),
               albumID,
               date,
               rank);
        }
    }
}
