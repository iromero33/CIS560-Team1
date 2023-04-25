using MusicDatabase.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MusicDatabase.DataDelegates
{
    internal class CreateBillboardDataDelegate : NonQueryDataDelegate<Billboard>
    {
        public readonly int albumId;
        public readonly DateTimeOffset date;
        public readonly int rank;

        public CreateBillboardDataDelegate(int albumId, DateTimeOffset date, int rank)
           : base("Music.CreateBillboard")
        {
            this.albumId = albumId;
            this.date = date;
            this.rank = rank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumId);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Rank", rank);

            var p = command.Parameters.Add("BillboardID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Billboard Translate(SqlCommand command)
        {
            return new Billboard((int)command.Parameters["AlbumID"].Value, albumId, date, rank);
        }
    }
}
