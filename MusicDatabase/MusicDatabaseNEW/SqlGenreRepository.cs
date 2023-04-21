using DataAccess;
using MusicDatabase.Models;
using MusicDatabase.DataDelegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDatabase
{
    public class SqlGenreRepository : IGenreRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGenreRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Genre CreateGenre(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateGenreDataDelegate(name);
            return executor.ExecuteNonQuery(d);
        }

        public Genre FetchGenre(int genreID)
        {
            var d = new FetchGenreDataDelegate(genreID);
            return executor.ExecuteReader(d);
        }

        public Genre GetGenre(string name)
        {
            var d = new GetGenreDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Genre> RetrieveGenres()
        {
            return executor.ExecuteReader(new RetrieveGenreDataDelegate());
        }
    }
}
