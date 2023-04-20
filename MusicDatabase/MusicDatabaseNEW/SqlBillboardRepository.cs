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

        public Billboard CreateBillboard(int albumId, DateTimeOffset start, DateTimeOffset end)
        {
            var d = new CreateBillboardDataDelegate(albumId, start, end);
            return executor.ExecuteNonQuery(d);
        }

        public Billboard FetchBillboard(int billboardID)
        {
            var d = new FetchBillboardDataDelegate(billboardID);
            return executor.ExecuteReader(d);
        }

        public Billboard GetBillboard(int albumID, DateTimeOffset startDate, DateTimeOffset endDate)
        {
            var d = new GetBillboardDataDelegate(albumID, startDate, endDate);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Billboard> RetrieveBillboards()
        {
            return executor.ExecuteReader(new RetrieveBillboardDataDelegate());
        }
    }
}
