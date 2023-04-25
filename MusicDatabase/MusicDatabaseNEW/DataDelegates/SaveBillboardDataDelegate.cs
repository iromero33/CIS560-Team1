using MusicDatabase.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MusicDatabase.DataDelegates
{
    internal class SaveBillboardDataDelegate : DataDelegate
    {
        public readonly int billboardID;
        public readonly int albumId;
        public readonly DateTimeOffset date;
        public readonly int rank;

        public SaveBillboardDataDelegate(int billboardID, int albumId, DateTimeOffset date, int rank)
           : base("Music.SaveBillboard")
        {
            this.billboardID = billboardID;
            this.albumId = albumId;
            this.date = date;
            this.rank = rank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("BillboardID", billboardID);
            command.Parameters.AddWithValue("AlbumID", albumId);
            command.Parameters.AddWithValue("WeekPosted", date);
            command.Parameters.AddWithValue("WeekRanking", rank);
        }
    }
}
