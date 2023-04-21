using DataAccess;
using MusicDatabase.Models;
using MusicDatabase.DataDelegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDatabase
{
    public class SqlAlbumRepository : IAlbumRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAlbumRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Album CreateAlbum(string name, DateTimeOffset releaseDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateAlbumDataDelegate(name, releaseDate);
            return executor.ExecuteNonQuery(d);
        }

        public Album FetchAlbum(int albumID)
        {
            var d = new FetchAlbumDataDelegate(albumID);
            return executor.ExecuteReader(d);
        }

        public Album GetAlbum(string name)
        {
            var d = new GetAlbumDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Album> RetrieveAlbums()
        {
            return executor.ExecuteReader(new RetrieveAlbumDataDelegate());
        }

        public IReadOnlyList<Album> GetAlbumsByYear(DateTimeOffset Year)
        {
            return executor.ExecuteReader(new GetAlbumsByYearDataDelegate(Year));
        }
    }
}
