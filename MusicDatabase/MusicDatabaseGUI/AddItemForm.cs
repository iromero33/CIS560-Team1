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
        
        public AddItemForm()
        {
            InitializeComponent();
        }

        public void InitializeForm (ItemType type)
        {
            HideAllOptions();
            IsNewItem = false;
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
                    uxNameLabel.Text = "Artist Name";

                    uxOtherLabel.Text = "Streaming Service";
                    uxOtherInput.Visible = true;
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

        public void EditArtist()
        {
            InitializeForm(ItemType.Artist);
            IsNewItem = true;
        }

        private void uxOkButton_Click(object sender, EventArgs e)
        {
            if (IsNewItem)
            {

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
