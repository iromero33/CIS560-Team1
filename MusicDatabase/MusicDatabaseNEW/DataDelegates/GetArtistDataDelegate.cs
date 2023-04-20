using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class GetArtistDataDelegate : DataReaderDelegate<Artist>
    {
        private readonly string name;

        public GetArtistDataDelegate(string name)
           : base("Music.GetArtist")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Artist Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Artist(
               reader.GetInt32("ArtistID"),
               reader.GetInt32("SongID"),
               name);
        }
    }
}
