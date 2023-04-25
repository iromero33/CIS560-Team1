using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicDatabase;
using MusicDatabase.Models;

namespace MusicDatabaseGUI
{
    public class Controller
    {
        private AddItemDel AddNewItem;

        /// <summary>
        /// Connection String Example: @"Server=(localdb)\MSSQLLocalDb;Database=DATABASE;Integrated Security=SSPI;"
        /// </summary>
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=MusicDatabase;Integrated Security=SSPI;";

        private ISongRepository songRepository = new SqlSongRepository(connectionString);
        private IAlbumRepository albumRepository = new SqlAlbumRepository(connectionString);
        private IArtistRepository artistRepository = new SqlArtistRepository(connectionString);
        private IGenreRepository genreRepository = new SqlGenreRepository(connectionString);

        public void SetAddNewItemDel(AddItemDel del)
        {
            AddNewItem = del;
        }

        public void AddItemOfType(ItemType item)
        {
            AddNewItem(item);
        }

        public IReadOnlyList<Album> GetAlbums()
        {
            return albumRepository.RetrieveAlbums();
        }

        public IReadOnlyList<Song> GetSongs()
        {
            return songRepository.RetrieveSongs();
        }

        public IReadOnlyList<Artist> GetArtists()
        {
            return artistRepository.RetrieveArtists();
        }

        public IReadOnlyList<Genre> GetGenres()
        {
            return genreRepository.RetrieveGenres();
        }

        public void CreateAlbum(string name, DateTimeOffset releaseDate)
        {
            albumRepository.CreateAlbum(name, releaseDate);
        }

        public void CreateSong(string title, int artistID, int albumID, int genreID, int spotifyListens)
        {
            songRepository.CreateSong(title, artistID, albumID, genreID, spotifyListens);
        }

        public void CreateArtist(string name)
        {
            artistRepository.CreateArtist(name);
        }

        public Song FetchSong(int songID)
        {
            return songRepository.FetchSong(songID);
        }

        public Album FetchAlbum(int albumID)
        {
            return albumRepository.FetchAlbum(albumID);
        }

        public Artist FetchArtist(int artistID)
        {
            return artistRepository.FetchArtist(artistID);
        }

        public Genre FetchGenre(int genreID)
        {
            return genreRepository.FetchGenre(genreID);
        }

        public IReadOnlyList<Song> GetSongsByTitle(string title)
        {
            return songRepository.GetSongsByTitle(title);
        }

        public IReadOnlyList<Song> GetSongsByAlbum(int albumID)
        {
            return songRepository.GetSongsByAlbum(albumID);
        }

        public IReadOnlyList<Album> GetAlbumsByYear(DateTimeOffset year)
        {
            return albumRepository.GetAlbumsByYear(year);
        }

        public IReadOnlyList<Song> GetSongsByReleaseDate(DateTimeOffset date) => songRepository.GetSongsByReleaseDate(date);

        public IReadOnlyList<Song> GetSongsBySpotifyListens(int min, int max) => songRepository.GetSongsBySpotifyListens(min, max);

        public IReadOnlyList<Song> GetSongsBySpotifyListensASC() => songRepository.GetSongsBySpotifyListensASC();

        public IReadOnlyList<Song> GetSongsBySpotifyListensDESC() => songRepository.GetSongsBySpotifyListensDESC();

        public IReadOnlyList<Song> GetSongsWithMostSpotifyListensPerMonth() => songRepository.GetSongsWithMostSpotifyListensPerMonth();

        public int GetAlbumPeakOnBillboard(int albumID) => albumRepository.GetAlbumPeakOnBillboard(albumID);

        public int GetAlbumLongestBillboardAppearance(int albumID) => albumRepository.GetAlbumLongestBillboardAppearance(albumID);

        public int GetAlbumAppearancesOnBillboard(int albumID) => albumRepository.GetAlbumAppearancesOnBillboard(albumID);

        public IReadOnlyList<Song> GetSongsWithHighestRankAlbumForWeek(DateTimeOffset week) => songRepository.GetSongsWithHighestRankAlbumForWeek(week);
    }
}
