using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;

namespace MusicDatabase.DataDelegates
{
    internal class RetrieveArtistDataDelegate : DataReaderDelegate<IReadOnlyList<Artist>>
    {
        public RetrieveArtistDataDelegate()
            : base("Music.RetrieveArtist")
        {
        }

        public override IReadOnlyList<Artist> Translate(SqlCommand command, IDataRowReader reader)
        {
            var artists = new List<Artist>();

            while (reader.Read())
            {
                artists.Add(new Artist(
                    reader.GetInt32("ArtistID"),
                    //reader.GetInt32("SongID"),
                    reader.GetString("Name")));
            }

            return artists;
        }
    }
}
