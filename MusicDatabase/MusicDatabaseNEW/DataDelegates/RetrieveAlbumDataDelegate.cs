using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;

namespace MusicDatabase.DataDelegates
{
    internal class RetrieveAlbumDataDelegate : DataReaderDelegate<IReadOnlyList<Album>>
    {
        public RetrieveAlbumDataDelegate()
            : base("Music.RetrieveAlbum")
        {
        }

        public override IReadOnlyList<Album> Translate(SqlCommand command, IDataRowReader reader)
        {
            var albums = new List<Album>();

            while (reader.Read())
            {
                albums.Add(new Album(
                    reader.GetInt32("AlbumID"),
                    reader.GetString("Name"),
                    reader.GetDateTimeOffset("ReleaseDate")));
            }

            return albums;
        }
    }
}
