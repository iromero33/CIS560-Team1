using System;
using System.Collections.Generic;
using System.Text;
using MusicDatabase.Models;


namespace MusicDatabase
{
    public interface IBillboardRepository
    {
        IReadOnlyList<Billboard> RetrieveBillboards();

        Billboard FetchBillboard(int billboardID);

        Billboard GetBillboard(int albumID, DateTimeOffset date);

        Billboard CreateBillboard(int albumId, DateTimeOffset date, int rank);

        void SaveBillboard(int albumID, DateTimeOffset date, int rank);
    }
}
