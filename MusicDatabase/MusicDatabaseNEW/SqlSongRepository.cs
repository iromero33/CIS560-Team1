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
            string titleAsSubstring = $"%{title}%";
            return executor.ExecuteReader(new GetSongsByTitleDataDelegate(titleAsSubstring));
        }

        public IReadOnlyList<Song> GetSongsByAlbum(int albumID)
        {
            return executor.ExecuteReader(new GetSongsByAlbumDataDelegate(albumID));
        }

        public IReadOnlyList<Song> GetSongsByReleaseDate(DateTimeOffset date)
        {
            return executor.ExecuteReader(new GetSongByReleaseDateDelegate(date));
        }

        public IReadOnlyList<Song> GetSongsBySpotifyListens(int min, int max)
        {
            return executor.ExecuteReader(new GetSongBySpotifyListensDelegate(min, max));
        }

        public IReadOnlyList<Song> GetSongsBySpotifyListensASC()
        {
            return executor.ExecuteReader(new GetSongsBySpotifyListensASCDataDelegate());
        }

        public IReadOnlyList<Song> GetSongsBySpotifyListensDESC()
        {
            return executor.ExecuteReader(new GetSongsBySpotifyListensDESCDataDelegate());
        }

        public IReadOnlyList<Song> GetSongsWithMostSpotifyListensPerMonth()
        {
            return executor.ExecuteReader(new GetSongsWithMostSpotifyListensPerMonthDataDelegate());
        }

        public IReadOnlyList<Song> GetSongsWithHighestRankAlbumForWeek(DateTimeOffset week)
        {
            return executor.ExecuteReader(new GetSongsWithHighestRankAlbumForWeekDataDelegate(week));
        }

        public IReadOnlyList<Song> GetSongsByBillboardNumWeeks(int numWeeks)
        {
            return executor.ExecuteReader(new GetSongsByBillboardNumWeeksDataDelegate(numWeeks));
        }

    }
}
