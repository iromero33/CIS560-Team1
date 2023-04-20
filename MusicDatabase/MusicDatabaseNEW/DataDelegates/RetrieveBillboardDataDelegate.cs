using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;

namespace MusicDatabase.DataDelegates
{
    internal class RetrieveBillboardDataDelegate : DataReaderDelegate<IReadOnlyList<Billboard>>
    {
        public RetrieveBillboardDataDelegate()
            : base("Music.RetrieveBillboard")
        {
        }

        public override IReadOnlyList<Billboard> Translate(SqlCommand command, IDataRowReader reader)
        {
            var billboards = new List<Billboard>();

            while (reader.Read())
            {
                billboards.Add(new Billboard(
                    reader.GetInt32("BillboardID"),
                    reader.GetInt32("AlbumID"),
                    reader.GetDateTimeOffset("StartDate"),
                    reader.GetDateTimeOffset("EndDate")));
            }

            return billboards;
        }
    }
}
