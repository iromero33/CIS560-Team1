using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;
using System.Xml.Linq;

namespace MusicDatabase.DataDelegates
{
    internal class GetAlbumsByYearDataDelegate : DataReaderDelegate<IReadOnlyList<Album>>
    {
        private readonly DateTimeOffset year;
        
        public GetAlbumsByYearDataDelegate(DateTimeOffset year)
            : base("Music.GetAlbumsByYear")
        {
            this.year = year;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Year", year);
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
