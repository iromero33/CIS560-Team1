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
    public partial class MusicDatabaseForm : Form
    {
        private AddItemDel AddItemOfType;
        
        public MusicDatabaseForm()
        {
            InitializeComponent();
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
        }
    }
}
