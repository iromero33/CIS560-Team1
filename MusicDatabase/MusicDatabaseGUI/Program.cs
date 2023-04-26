using MusicDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDatabaseGUI
{
    public delegate void AddItemDel(ItemType addItemType);

    public delegate IReadOnlyList<Album> GetAlbumsDel();
    public delegate IReadOnlyList<Artist> GetArtistsDel();
    public delegate IReadOnlyList<Genre> GetGenresDel();
    public delegate IReadOnlyList<Song> GetSongsDel();
    public delegate IReadOnlyList<Song> GetSongsByTitleDel(string title);
    public delegate IReadOnlyList<Song> GetSongsByAlbumDel(int albumID);
    public delegate IReadOnlyList<Song> GetSongsByReleaseDateDel(DateTimeOffset date);
    public delegate IReadOnlyList<Song> GetSongsBySpotifyListensDel(int min, int max);
    public delegate IReadOnlyList<Song> GetSongsWithMostSpotifyListensPerMonthDel();
    public delegate IReadOnlyList<Album> GetAlbumsByYearDel(DateTimeOffset year);
    public delegate int GetAlbumBillboardDataDel(int albumID);
    public delegate IReadOnlyList<Song> GetSongsBySpotifyListensOrderedDel();
    public delegate IReadOnlyList<Song> GetSongsWithHighestRankAlbumForWeekDel(DateTimeOffset week);
    public delegate void UpdateBillboardWeekDel(int albumID, DateTimeOffset date, int rank);
    public delegate IReadOnlyList<Song> GetSongsByBillboardNumWeeksDel(int numWeeks);

    public delegate void CreateAlbumDel(string name, DateTimeOffset releaseDate);
    public delegate void CreateSongDel(string title, int artistID, int albumID, int genreID, int spotifyListens);
    public delegate void CreateArtistDel(string name);

    public delegate Song FetchSongDel(int songID);
    public delegate Album FetchAlbumDel(int albumID);
    public delegate Artist FetchArtistDel(int artistID);
    public delegate Genre FetchGenreDel(int genreID);

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller controller = new Controller();

            MusicDatabaseForm form = new MusicDatabaseForm(controller.GetAlbums, controller.GetArtists, controller.GetGenres, controller.GetSongs, 
                controller.GetSongsByTitle, controller.GetSongsByAlbum, controller.GetAlbumsByYear, 
                controller.GetSongsByReleaseDate, controller.GetSongsBySpotifyListens, controller.GetSongsWithMostSpotifyListensPerMonth,
                controller.GetAlbumAppearancesOnBillboard, controller.GetAlbumLongestBillboardAppearance, controller.GetAlbumPeakOnBillboard, 
                controller.GetSongsBySpotifyListensASC, controller.GetSongsBySpotifyListensDESC, controller.GetSongsWithHighestRankAlbumForWeek, controller.GetSongsByBillboardNumWeeks);

            AddItemForm addForm = new AddItemForm(controller.GetAlbums, controller.GetArtists, controller.GetGenres);

            //Should eventually populate lists in forms using BindingLists of songs, albums, etc. stored in Controller

            form.SetAddItemDel(controller.AddItemOfType);
            form.SetFetchDels(controller.FetchSong, controller.FetchAlbum, controller.FetchArtist, controller.FetchGenre);
            controller.SetAddNewItemDel(addForm.InitializeForm);
            addForm.SetCreateItemDels(controller.CreateAlbum, controller.CreateSong, controller.CreateArtist, controller.UpdateBillboard);


            Application.Run(form);
        }
    }
}
