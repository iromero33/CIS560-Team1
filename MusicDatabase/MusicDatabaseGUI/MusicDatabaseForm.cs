using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicDatabase.Models;

namespace MusicDatabaseGUI
{
    //Eventually add different searches of songs based on queries we decide on implementing
    public partial class MusicDatabaseForm : Form
    {
        private AddItemDel AddItemOfType;

        private GetAlbumsDel GetAlbums;
        private GetArtistsDel GetArtists;
        private GetGenresDel GetGenres;
        private GetSongsDel GetSongs;

        private FetchSongDel FetchSong;
        private FetchAlbumDel FetchAlbum;
        private FetchArtistDel FetchArtist;
        private FetchGenreDel FetchGenre;

        private Song SelectedSong;

        public MusicDatabaseForm(GetAlbumsDel albumsDel, GetArtistsDel artistsDel, GetGenresDel genresDel, GetSongsDel songsDel)
        {
            InitializeComponent();

            uxReleaseDateInput.CustomFormat = "MMMM yyyy";

            GetAlbums = albumsDel;
            GetArtists = artistsDel;
            GetGenres = genresDel;
            GetSongs = songsDel;

            uxSongsList.DataSource = GetSongs();
            uxAlbumList.DataSource = GetAlbums();
            uxArtistList.DataSource = GetArtists();
            uxGenreList.DataSource = GetGenres();
        }

        public void SetAddItemDel(AddItemDel del)
        {
            AddItemOfType = del;
        }

        public void SetFetchDels(FetchSongDel songDel, FetchAlbumDel albumDel, FetchArtistDel artistDel, FetchGenreDel genreDel)
        {
            FetchSong = songDel;
            FetchAlbum = albumDel;
            FetchArtist = artistDel;
            FetchGenre = genreDel;
        }

        private void AddItem(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "uxAddArtistButton":
                        AddItemOfType(ItemType.Artist);
                        updateListsOfType(ItemType.Artist);
                        break;
                    case "uxAddAlbumButton":
                        AddItemOfType(ItemType.Album);
                        updateListsOfType(ItemType.Album);
                        break;
                    case "uxAddSongButton":
                        AddItemOfType(ItemType.Song);
                        updateListsOfType(ItemType.Song);
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void uxSearchSongButton_Click(object sender, EventArgs e)
        {
            string term = uxSongTextBox.Text;
            //Should query the songs by name based on search term
        }

        private void uxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxArtistList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxGenreList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxSearchByButton_Click(object sender, EventArgs e)
        {
            int numSpotifyListens = (int)uxSpotifyListensInput.Value;
            
        }

        private void uxSearchWeeksButton_Click(object sender, EventArgs e)
        {
            int numWeeks = (int)uxBillboardWeeksInput.Value;
        }

        private void uxSearchDateButton_Click(object sender, EventArgs e)
        {
            DateTime searchDate = uxReleaseDateInput.Value;

        }

        private void updateListsOfType(ItemType type)
        {
            switch (type)
            {
                case ItemType.Album:
                    uxAlbumList.DataSource = GetAlbums();
                    break;
                case ItemType.Artist:
                    uxArtistList.DataSource = GetArtists();
                    break;
                case ItemType.Song:
                    uxSongsList.DataSource = GetSongs();
                    break;
                case ItemType.Genre:
                    uxGenreList.DataSource = GetGenres();
                    break;
                default:
                    break;
            }
        }

        private void uxSongsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxSongsList.SelectedItem is Song song)
            {
                SelectedSong = FetchSong(song.SongID);

                uxSpotifyListensOutput.Text = SelectedSong.SpotifyListens.ToString();

                uxSongArtistOutput.Text = FetchArtist(SelectedSong.ArtistID).Name;
                uxSongAlbumOutput.Text = FetchAlbum(SelectedSong.AlbumID).Name;
                uxSongGenreOutput.Text = FetchGenre(SelectedSong.GenreID).Name;
            }
            
        }
    }
}
