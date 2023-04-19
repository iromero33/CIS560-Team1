﻿using MusicDatabase.Models;
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

        //private Song song;
        //private Album album;
        //private Artist artist;
        
        public AddItemForm()
        {
            InitializeComponent();
        }

        public void InitializeForm (ItemType type)
        {
            HideAllOptions();
            IsNewItem = false;
            CurrItemType = type;

            switch (type)
            {
                case ItemType.Album:
                    Text = "Add Album";
                    uxNameLabel.Text = "Album Name";

                    uxArtistLabel.Visible = true;
                    uxArtistMenu.Visible = true;
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
            IsNewItem = true;
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
                        
                        int artistID = ((Artist)uxArtistMenu.SelectedValue).ArtistID;
                        DateTime releaseDate = uxReleaseDateInput.Value;

                        //Create Album
                        break;
                    case ItemType.Artist:
                        //Create Artist
                        break;
                    case ItemType.Song:
                        artistID = ((Artist)uxArtistMenu.SelectedValue).ArtistID;
                        int albumID = ((Album)uxAlbumMenu.SelectedValue).AlbumID;
                        int genreID = ((Genre)uxGenreMenu.SelectedValue).GenreID;

                        //Create Song
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
            uxReleaseDateInput.Visible = false;
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
