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
        private GetSongsByTitleDel GetSongsByTitle;
        private GetSongsByAlbumDel GetSongsByAlbum;
        private GetAlbumsByYearDel GetAlbumsByYear;
        private GetSongsByReleaseDateDel GetSongsByReleaseDate;
        private GetSongsBySpotifyListensDel GetSongsBySpotifyListens;

        private FetchSongDel FetchSong;
        private FetchAlbumDel FetchAlbum;
        private FetchArtistDel FetchArtist;
        private FetchGenreDel FetchGenre;

        private Song SelectedSong;

        public MusicDatabaseForm(GetAlbumsDel albumsDel, GetArtistsDel artistsDel, GetGenresDel genresDel, GetSongsDel songsDel, GetSongsByTitleDel songsByTitleDel, GetSongsByAlbumDel songsByAlbumDel, GetAlbumsByYearDel albumsByYearDel, GetSongsByReleaseDateDel songsByDateDel, GetSongsBySpotifyListensDel songsByListensDel)
        {
            InitializeComponent();

            uxReleaseDateInput.CustomFormat = "dd MMMM yyyy";
            uxAlbumYearInput.CustomFormat = "yyyy";

            GetAlbums = albumsDel;
            GetArtists = artistsDel;
            GetGenres = genresDel;
            GetSongs = songsDel;
            GetSongsByTitle = songsByTitleDel;
            GetSongsByAlbum = songsByAlbumDel;
            GetAlbumsByYear = albumsByYearDel;
            GetSongsBySpotifyListens = songsByListensDel;
            GetSongsByReleaseDate = songsByDateDel;

            uxSongsList.DataSource = GetSongs();
            uxAlbumList.DataSource = GetAlbums();
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

        private void uxSearchByButton_Click(object sender, EventArgs e)
        {
            int numSpotifyListens = (int)uxSpotifyListensInput.Value;
            uxSongsList.DataSource = GetSongsBySpotifyListens(0, numSpotifyListens);
        }

        private void uxSearchWeeksButton_Click(object sender, EventArgs e)
        {
            int numWeeks = (int)uxBillboardWeeksInput.Value;
        }

        private void uxSearchDateButton_Click(object sender, EventArgs e)
        {
            DateTimeOffset searchDate = uxReleaseDateInput.Value;
            uxSongsList.DataSource = GetSongsByReleaseDate(searchDate);

        }

        private void updateListsOfType(ItemType type)
        {
            switch (type)
            {
                case ItemType.Album:
                    uxAlbumList.DataSource = GetAlbums();
                    break;
                case ItemType.Song:
                    uxSongsList.DataSource = GetSongs();
                    break;
                default:
                    break;
            }
        }

        private void uxSongsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FetchSong != null && uxSongsList.SelectedIndex >= 0 && uxSongsList.SelectedItem is Song song)
            {
                SelectedSong = FetchSong(song.SongID);

                uxSongTitleOutput.Text = SelectedSong.Title;
                uxSpotifyListensOutput.Text = SelectedSong.SpotifyListens.ToString();
                uxSongArtistOutput.Text = FetchArtist(SelectedSong.ArtistID).Name;
                uxSongAlbumOutput.Text = FetchAlbum(SelectedSong.AlbumID).Name;
                uxSongGenreOutput.Text = FetchGenre(SelectedSong.GenreID).Name;
            } 
            else
            {
                uxSongsList.SelectedIndex = -1;

                uxSongTitleOutput.Text = "";
                uxSpotifyListensOutput.Text = "";
                uxSongArtistOutput.Text = "";
                uxSongAlbumOutput.Text = "";
                uxSongGenreOutput.Text = "";
            }
            
        }

        private void uxSongTextBox_TextChanged(object sender, EventArgs e)
        {
            string title = uxSongTextBox.Text;
            if (title != "")
            {
                uxSongsList.DataSource = GetSongsByTitle(title);
            } 
            else
            {
                uxSongsList.DataSource = GetSongs();
            }
        }

        private void uxUseDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxAlbumYearInput.Enabled = uxUseDateCheckBox.Checked)
            {
                uxAlbumList.DataSource = GetAlbumsByYear(uxAlbumYearInput.Value);
            } 
            else
            {
                uxAlbumList.DataSource = GetAlbums();
            }
        }

        private void uxSearchByItems_Click(object sender, EventArgs e)
        {
            Album album = (Album)uxAlbumList.SelectedValue;

            uxSongsList.DataSource = GetSongsByAlbum(album.AlbumID);
        }

        private void uxAlbumYearInput_ValueChanged(object sender, EventArgs e)
        {
            uxAlbumList.DataSource = GetAlbumsByYear(uxAlbumYearInput.Value);
        }

        private void uxClearSearchButton_Click(object sender, EventArgs e)
        {
            uxSongsList.DataSource = GetSongs();
            uxSongTextBox.Text = "";
            uxSongsList.SelectedIndex = -1;
        }
    }
}
