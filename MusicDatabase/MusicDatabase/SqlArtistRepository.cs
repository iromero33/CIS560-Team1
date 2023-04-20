using DataAccess;
using MusicDatabase.Models;
using MusicDatabase.DataDelegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDatabase
{
    class SqlArtistRepository : IArtistRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlArtistRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Artist CreateArtist(string name, int songId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateArtistDataDelegate(name, songId);
            return executor.ExecuteNonQuery(d);
        }

        public Artist FetchArtist(int artistID)
        {
            var d = new FetchArtistDataDelegate(artistID);
            return executor.ExecuteReader(d);
        }

        public Artist GetArtist(string name)
        {
            var d = new GetArtistDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Artist> RetrieveArtists()
        {
            return executor.ExecuteReader(new RetrieveArtistDataDelegate());
        }
    }
}
