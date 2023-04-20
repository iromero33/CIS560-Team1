using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MusicDatabase.Models;

namespace MusicDatabase
{
    internal class RetrieveGenreDataDelegate : DataReaderDelegate<IReadOnlyList<Genre>>
    {
        public RetrieveGenreDataDelegate()
            : base("Music.RetrieveGenre")
        {
        }

        public override IReadOnlyList<Genre> Translate(SqlCommand command, IDataRowReader reader)
        {
            var genres = new List<Genre>();

            while (reader.Read())
            {
                genres.Add(new Genre(
                    reader.GetInt32("GenreID"),
                    reader.GetString("Name")));
            }

            return genres;
        }
    }
}
