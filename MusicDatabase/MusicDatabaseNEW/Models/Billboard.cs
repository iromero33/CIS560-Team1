using System;

namespace MusicDatabase.Models
{
    public class Billboard
    {
        public int BillboardID { get; }

        public int AlbumID { get; }

        public DateTimeOffset Date { get; }

        public int Rank { get; }

        internal Billboard(int billboardId, int albumId, DateTimeOffset date, int rank)
        {
            BillboardID = billboardId;
            AlbumID = albumId;
            Date = date;
            Rank = rank;
        }
    }
}

