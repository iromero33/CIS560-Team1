using System;

namespace MusicDatabase.Models
{
    public class Billboard
    {
        public int BillboardID { get; }

        public int AlbumID { get; }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }

        internal Billboard(int billboardId, int albumId, DateTime start, DateTime end)
        {
            BillboardID = billboardId;
            AlbumID = albumId;
            StartDate = start;
            EndDate = end;
        }
    }
}

