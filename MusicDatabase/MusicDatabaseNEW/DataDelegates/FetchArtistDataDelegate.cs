using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using MusicDatabase.Models;
using System.Data.SqlClient;

namespace MusicDatabase
{
    internal class FetchArtistDataDelegate : DataReaderDelegate<Artist>
    {
        private readonly int artistID;

        public FetchArtistDataDelegate(int artistID)
           : base("Music.FetchArtist")
        {
            this.artistID = artistID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ArtistID", artistID);
        }

        public override Artist Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(artistID.ToString());

            return new Artist(artistID,
               //reader.GetInt32("SongID"),
               reader.GetString("Name"));
        }
    }
}
