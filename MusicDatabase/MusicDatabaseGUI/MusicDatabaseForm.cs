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
    //Eventually add different searches of songs based on queries we decide on implementing
    public partial class MusicDatabaseForm : Form
    {
        private AddItemDel AddItemOfType;
        
        public MusicDatabaseForm()
        {
            InitializeComponent();

            uxReleaseDateInput.CustomFormat = "MMMM yyyy";
        }

        public void SetAddItemDel(AddItemDel del)
        {
            AddItemOfType = del;
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
                        break;
                    case "uxAddSongButton":
                        AddItemOfType(ItemType.Song);
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
    }
}
