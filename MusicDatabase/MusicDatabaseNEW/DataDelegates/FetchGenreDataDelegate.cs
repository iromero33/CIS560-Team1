using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class FetchGenreDataDelegate : DataReaderDelegate<Genre>
    {
        private readonly int genreID;

        public FetchGenreDataDelegate(int genreID)
           : base("Music.FetchGenre")
        {
            this.genreID = genreID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GenreID", genreID);
        }

        public override Genre Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(genreID.ToString());

            return new Genre(genreID,
               reader.GetString("Name"));
        }
    }
}
