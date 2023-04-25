using MusicDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDatabaseGUI
{
    public partial class AddItemForm : Form
    {
        private ItemType CurrItemType;

        private GetAlbumsDel GetAlbums;

        private GetArtistsDel GetArtists;

        private GetGenresDel GetGenres;

        private CreateAlbumDel CreateAlbum;

        private CreateSongDel CreateSong;

        private CreateArtistDel CreateArtist;

        private UpdateBillboardWeekDel UpdateBillboardWeek;

        private GetBillboardDel GetBillboard;

        public AddItemForm(GetAlbumsDel albumsDel, GetArtistsDel artistsDel, GetGenresDel genresDel, GetBillboardDel billboardDel)
        {
            InitializeComponent();

            GetAlbums = albumsDel;
            GetArtists = artistsDel;
            GetGenres = genresDel;
            GetBillboard = billboardDel;

            uxAlbumMenu.DataSource = GetAlbums();
            uxArtistMenu.DataSource = GetArtists();
            uxGenreMenu.DataSource = GetGenres();
        }

        public void SetCreateItemDels(CreateAlbumDel createAlbum, CreateSongDel createSong, CreateArtistDel createArtist, UpdateBillboardWeekDel updateBillboard)
        {
            CreateAlbum = createAlbum;
            CreateSong = createSong;
            CreateArtist = createArtist;
            UpdateBillboardWeek = updateBillboard;
        }

        public void InitializeForm (ItemType type)
        {
            HideAllOptions();
            CurrItemType = type;
            uxItemNameInput.Text = "";

            uxAlbumMenu.DataSource = GetAlbums();
            uxArtistMenu.DataSource = GetArtists();
            uxGenreMenu.DataSource = GetGenres();

            switch (type)
            {
                case ItemType.Album:
                    Text = "Add Album";
                    uxNameLabel.Text = "Album Name";
                    uxOtherLabel.Text = "Release Date";
                    uxReleaseDateInput.Visible = true;
                    uxReleaseDateInput.Value = DateTime.Today;
                    break;
                case ItemType.Artist:
                    Text = "Add Artist";
                    uxOtherLabel.Text = "";
                    uxNameLabel.Text = "Artist Name";
                    break;
                case ItemType.Song:
                    Text = "Add Song";
                    uxNameLabel.Text = "Song Title";

                    uxArtistLabel.Visible = true;
                    uxAlbumLabel.Visible = true;
                    uxGenreLabel.Visible = true;
                    uxArtistMenu.Visible = true;
                    uxAlbumMenu.Visible = true;
                    uxGenreMenu.Visible = true;
                    uxOtherLabel.Text = "Spotify Listens";
                    uxOtherInput.Visible = true;
                    break;
                case ItemType.Billboard:
                    Text = "Update Chart Week";
                    uxNameLabel.Text = "Rank";

                    uxRankInput.Visible = true;
                    uxRankInput.Value = 1;
                    uxAlbumLabel.Visible = true;
                    uxAlbumMenu.Visible = true;
                    uxOtherLabel.Text = "Week of:";
                    uxReleaseDateInput.Visible = true;

                    break;
                default:
                    return;
            }

            ShowDialog();
        }

        private void uxOkButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            string name = "";

            if (uxItemNameInput.Text != "") name = uxItemNameInput.Text;
            else if (CurrItemType != ItemType.Billboard)
            {
                isValid = false;
                MessageBox.Show("Error: No name / title input");
            }

            if (isValid)
            {
                //Add new item to database
                

                switch(CurrItemType)
                {
                    case ItemType.Album:
                        DateTime releaseDate = uxReleaseDateInput.Value;
                        CreateAlbum(name, releaseDate);
                        break;
                    case ItemType.Artist:
                        //REMEMBER TO ASK: WHAT TO DO ABOUT SONGARTIST RELATIONSHIP?
                        CreateArtist(name);
                        break;
                    case ItemType.Song:
                        int artistID = ((Artist)uxArtistMenu.SelectedValue).ArtistID;
                        int albumID = ((Album)uxAlbumMenu.SelectedValue).AlbumID;
                        int genreID = ((Genre)uxGenreMenu.SelectedValue).GenreID;
                        if (isValid = Int32.TryParse(uxOtherInput.Text, out int spotifyListens))
                        {
                            CreateSong(name, artistID, albumID, genreID, spotifyListens);
                        }
                        else
                        {
                            MessageBox.Show("Error: Inputted spotify listens is not a number");
                        }
                        
                        
                        break;
                    case ItemType.Billboard:
                        DateTime weekOf = uxReleaseDateInput.Value;
                        albumID = ((Album)uxAlbumMenu.SelectedValue).AlbumID;
                        int rank = (int)uxRankInput.Value;

                        Billboard billboard = GetBillboard(albumID, weekOf);
                        if (billboard != null) UpdateBillboardWeek(billboard.BillboardID, albumID, weekOf, rank);
                        break;
                    default:
                        break;
                }
            }
            if (isValid)this.Close();
        }

        private void HideAllOptions()
        {
            uxArtistLabel.Visible = false;
            uxAlbumLabel.Visible = false;
            uxGenreLabel.Visible = false;

            uxArtistMenu.Visible = false;
            uxAlbumMenu.Visible = false;
            uxGenreMenu.Visible = false;

            uxOtherInput.Visible = false;
            uxOtherInput.Text = "";
            uxReleaseDateInput.Visible = false;
            uxRankInput.Visible = false;
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
