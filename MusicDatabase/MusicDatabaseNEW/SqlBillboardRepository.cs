using DataAccess;
using MusicDatabase.Models;
using MusicDatabase.DataDelegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDatabase
{
    public class SqlBillboardRepository : IBillboardRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlBillboardRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Billboard CreateBillboard(int albumId, DateTimeOffset date, int rank)
        {
            var d = new CreateBillboardDataDelegate(albumId, date, rank);
            return executor.ExecuteNonQuery(d);
        }

        public Billboard FetchBillboard(int billboardID)
        {
            var d = new FetchBillboardDataDelegate(billboardID);
            return executor.ExecuteReader(d);
        }

        public Billboard GetBillboard(int albumID, DateTimeOffset date)
        {
            var d = new GetBillboardDataDelegate(albumID, date);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Billboard> RetrieveBillboards()
        {
            return executor.ExecuteReader(new RetrieveBillboardDataDelegate());
        }

        public void SaveBillboard(int billboardID, int albumID, DateTimeOffset date, int rank)
        {
            executor.ExecuteNonQuery(new SaveBillboardDataDelegate(billboardID, albumID, date, rank));
        }
    }
}
