using MusicDatabase.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MusicDatabase.DataDelegates
{
    internal class CreateGenreDataDelegate : NonQueryDataDelegate<Genre>
    {
        public readonly string name;

        public CreateGenreDataDelegate(string name)
           : base("Music.CreateGenre")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);

            var p = command.Parameters.Add("GenreID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Genre Translate(SqlCommand command)
        {
            return new Genre((int)command.Parameters["GenreID"].Value, name);
        }
    }
}
