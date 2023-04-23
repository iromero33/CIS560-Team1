using DataAccess;
using MusicDatabase.Models;
using MusicDatabase.DataDelegates;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDatabase
{
    public class SqlSongRepository : ISongRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlSongRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Song CreateSong(string title, int artistID, int albumID, int genreID, int spotifyListens)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(title));

            var d = new CreateSongDataDelegate(title, artistID, albumID, genreID, spotifyListens);
            return executor.ExecuteNonQuery(d);
        }

        public Song FetchSong(int songID)
        {
            var d = new FetchSongDataDelegate(songID);
            return executor.ExecuteReader(d);
        }

        public Song GetSong(string title, int albumID)
        {
            var d = new GetSongDataDelegate(title, albumID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Song> RetrieveSongs()
        {
            return executor.ExecuteReader(new RetrieveSongDataDelegate());
        }

        public IReadOnlyList<Song> GetSongsByTitle(string title)
        {
            return executor.ExecuteReader(new GetSongsByTitleDataDelegate(title));
        }

        public IReadOnlyList<Song> GetSongsByAlbum(int albumID)
        {
            return executor.ExecuteReader(new GetSongsByAlbumDataDelegate(albumID));
        }

        public IReadOnlyList<Song> GetSongsByReleaseYear(DateTimeOffset date)
        {
            return executor.ExecuteReader(new GetSongByReleaseDateDelegate(date));
        }

        public IReadOnlyList<Song> GetSongsBySpotifyListens(int listens)
        {
            return executor.ExecuteReader(new GetSongBySpotifyListensDelegate(listens));
        }
    }
}
