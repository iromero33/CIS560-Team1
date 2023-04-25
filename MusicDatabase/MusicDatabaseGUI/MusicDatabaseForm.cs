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
        private GetSongsWithMostSpotifyListensPerMonthDel GetSongsWithMostSpotifyListensPerMonth;
        private GetAlbumBillboardDataDel GetBillboardAppearances;
        private GetAlbumBillboardDataDel GetConsecutiveWeeksOnBillboard;
        private GetAlbumBillboardDataDel GetAlbumPeak;
        private GetSongsBySpotifyListensOrderedDel GetBySpotifyListensASC;
        private GetSongsBySpotifyListensOrderedDel GetBySpotifyListensDESC;
        private GetSongsWithHighestRankAlbumForWeekDel GetSongsByAlbumRankForWeek;

        private FetchSongDel FetchSong;
        private FetchAlbumDel FetchAlbum;
        private FetchArtistDel FetchArtist;
        private FetchGenreDel FetchGenre;

        private Song SelectedSong;

        public MusicDatabaseForm(GetAlbumsDel albumsDel, GetArtistsDel artistsDel, GetGenresDel genresDel, GetSongsDel songsDel, 
            GetSongsByTitleDel songsByTitleDel, GetSongsByAlbumDel songsByAlbumDel, GetAlbumsByYearDel albumsByYearDel, 
            GetSongsByReleaseDateDel songsByDateDel, GetSongsBySpotifyListensDel songsByListensDel, GetSongsWithMostSpotifyListensPerMonthDel songsByListensMonthDel,
            GetAlbumBillboardDataDel billboardAppearancesDel, GetAlbumBillboardDataDel consecutiveWeeksOnBillboardDel, GetAlbumBillboardDataDel albumPeakDel,
            GetSongsBySpotifyListensOrderedDel byListensASCDel, GetSongsBySpotifyListensOrderedDel byListensDESCDel, GetSongsWithHighestRankAlbumForWeekDel songsbyAlbumRank)
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
            GetSongsWithMostSpotifyListensPerMonth = songsByListensMonthDel;
            GetBillboardAppearances = billboardAppearancesDel;
            GetConsecutiveWeeksOnBillboard = consecutiveWeeksOnBillboardDel;
            GetAlbumPeak = albumPeakDel;
            GetBySpotifyListensASC = byListensASCDel;
            GetBySpotifyListensDESC = byListensDESCDel;
            GetSongsByAlbumRankForWeek = songsbyAlbumRank;

            uxSongsList.DataSource = GetSongs();
            uxAlbumList.DataSource = GetAlbums();
            uxSearchMenuOption.Checked = true;
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
            int minSpotifyListens = (int)uxMinListensInput.Value;
            int maxSpotifyListens = (int)uxMaxListensInput.Value;

            uxSongsList.DataSource = GetSongsBySpotifyListens(minSpotifyListens, maxSpotifyListens);
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
                Album selectedSongAlbum = FetchAlbum(SelectedSong.AlbumID);

                uxSongTitleOutput.Text = SelectedSong.Title;
                uxSpotifyListensOutput.Text = SelectedSong.SpotifyListens.ToString();
                uxSongArtistOutput.Text = FetchArtist(SelectedSong.ArtistID).Name;
                uxSongAlbumOutput.Text = selectedSongAlbum.Name;
                uxSongGenreOutput.Text = FetchGenre(SelectedSong.GenreID).Name;
                uxSongReleaseDateOutput.Text = selectedSongAlbum.ReleaseDate.Date.ToLongDateString();
                uxAlbumBillboardOutput.Text = GetConsecutiveWeeksOnBillboard(SelectedSong.AlbumID).ToString();
            } 
            else
            {
                uxSongsList.SelectedIndex = -1;

                uxSongTitleOutput.Text = "";
                uxSpotifyListensOutput.Text = "";
                uxSongArtistOutput.Text = "";
                uxSongAlbumOutput.Text = "";
                uxSongGenreOutput.Text = "";
                uxSongReleaseDateOutput.Text = "";
                uxAlbumBillboardOutput.Text = "";
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

        private void uxSortBySpotifyListensPerMonthButton_Click(object sender, EventArgs e)
        {
            uxSongsList.DataSource = GetSongsWithMostSpotifyListensPerMonth();
        }

        private void uxSearchMenuOption_CheckedChanged(object sender, EventArgs e)
        {
            uxSearchOptions.Visible = true;
            uxAddOptions.Visible = false;
            uxQueryGroupBox.Visible = false;
        }

        private void uxAddMenuOption_CheckedChanged(object sender, EventArgs e)
        {
            uxSearchOptions.Visible = false;
            uxAddOptions.Visible = true;
            uxQueryGroupBox.Visible = false;
        }

        private void uxQueryMenuOption_CheckedChanged(object sender, EventArgs e)
        {
            uxSearchOptions.Visible = false;
            uxAddOptions.Visible = false;
            uxQueryGroupBox.Visible = true;
        }

        private void uxSpotifyListensASCQueryButton_Click(object sender, EventArgs e)
        {
            uxSongsList.DataSource = GetBySpotifyListensASC();
        }

        private void uxSpotifyListensDESCQueryButton_Click(object sender, EventArgs e)
        {
            uxSongsList.DataSource = GetBySpotifyListensDESC();
        }

        private void uxSongsByHighestRankAlbumByWeekQueryButton_Click(object sender, EventArgs e)
        {
            DateTimeOffset week = uxBillboardWeekQueryInput.Value;

            uxSongsList.DataSource = GetBySpotifyListensDESC();
        }
    }
}
