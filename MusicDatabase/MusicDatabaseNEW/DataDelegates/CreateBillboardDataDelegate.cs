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
        public readonly DateTimeOffset start;
        public readonly DateTimeOffset end;

        public CreateBillboardDataDelegate(int albumId, DateTimeOffset start, DateTimeOffset end)
           : base("Music.CreateBillboard")
        {
            this.albumId = albumId;
            this.start = start;
            this.end = end;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumId);
            command.Parameters.AddWithValue("StartDate", start);
            command.Parameters.AddWithValue("EndDate", end);

            var p = command.Parameters.Add("BillboardID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Billboard Translate(SqlCommand command)
        {
            return new Billboard((int)command.Parameters["AlbumID"].Value, albumId, start, end);
        }
    }
}
