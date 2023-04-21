using MusicDatabase.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicDatabase.DataDelegates
{
    internal class CreateArtistDataDelegate : NonQueryDataDelegate<Artist>
    {
        public readonly string name;

        public CreateArtistDataDelegate(string name)
           : base("Music.CreateArtist")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            //command.Parameters.AddWithValue("SongID", songId);

            var p = command.Parameters.Add("ArtistID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Artist Translate(SqlCommand command)
        {
            return new Artist((int)command.Parameters["ArtistID"].Value, /*songId,*/ name);
        }
    }
}
