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
        private bool IsNewItem;

        private ItemType CurrItemType;

        private GetAlbumsDel GetAlbums;

        private GetArtistsDel GetArtists;

        private GetGenresDel GetGenres;

        private CreateAlbumDel CreateAlbum;

        private CreateSongDel CreateSong;

        private CreateArtistDel CreateArtist;

        public AddItemForm(GetAlbumsDel albumsDel, GetArtistsDel artistsDel, GetGenresDel genresDel)
        {
            InitializeComponent();

            GetAlbums = albumsDel;
            GetArtists = artistsDel;
            GetGenres = genresDel;

            uxAlbumMenu.DataSource = GetAlbums();
            uxArtistMenu.DataSource = GetArtists();
            uxGenreMenu.DataSource = GetGenres();
        }

        public void SetCreateItemDels(CreateAlbumDel createAlbum, CreateSongDel createSong, CreateArtistDel createArtist)
        {
            CreateAlbum = createAlbum;
            CreateSong = createSong;
            CreateArtist = createArtist;
        }

        public void InitializeForm (ItemType type)
        {
            HideAllOptions();
            IsNewItem = true;
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
                default:
                    return;
            }

            ShowDialog();
        }

        /// <summary>
        /// Not necessary anymore?
        /// </summary>
        public void EditArtist()
        {
            InitializeForm(ItemType.Artist);
            IsNewItem = false;
            //Should eventually hook up to edit artist button in main form using delegates
        }

        private void uxOkButton_Click(object sender, EventArgs e)
        {
            if (IsNewItem)
            {
                //Add new item to database

                string name = uxItemNameInput.Text;

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
                        int genreID = 0;
                        if (uxGenreMenu.SelectedValue != null) genreID = ((Genre)uxGenreMenu.SelectedValue).GenreID;
                        int spotifyListens = Convert.ToInt32(uxOtherInput.Text);

                        CreateSong(name, artistID, albumID, genreID, spotifyListens);
                        break;
                    default:
                        break;
                }
            }
            this.Close();
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
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
