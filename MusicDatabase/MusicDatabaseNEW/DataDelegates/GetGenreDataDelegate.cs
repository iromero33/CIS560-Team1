using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetGenreDataDelegate : DataReaderDelegate<Genre>
    {
        private readonly string name;

        public GetGenreDataDelegate(string name)
           : base("Music.GetGenre")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Genre Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Genre(
               reader.GetInt32("GenreID"),
               name);
        }
    }
}
