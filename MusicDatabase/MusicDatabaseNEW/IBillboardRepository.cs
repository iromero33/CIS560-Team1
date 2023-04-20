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

        Billboard GetBillboard(int albumID, DateTimeOffset startDate, DateTimeOffset endDate);

        Billboard CreateBillboard(int albumId, DateTimeOffset start, DateTimeOffset end);
    }
}
