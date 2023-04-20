using System;

namespace MusicDatabase.Models
{
    public class Billboard
    {
        public int BillboardID { get; }

        public int AlbumID { get; }

        public DateTimeOffset StartDate { get; }

        public DateTimeOffset EndDate { get; }

        internal Billboard(int billboardId, int albumId, DateTimeOffset start, DateTimeOffset end)
        {
            BillboardID = billboardId;
            AlbumID = albumId;
            StartDate = start;
            EndDate = end;
        }
    }
}

