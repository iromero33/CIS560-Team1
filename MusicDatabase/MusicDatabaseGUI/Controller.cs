using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabaseGUI
{
    public class Controller
    {
        private AddItemDel AddNewItem;

        public void SetAddNewItemDel(AddItemDel del)
        {
            AddNewItem = del;
        }

        public void AddItemOfType(ItemType item)
        {
            AddNewItem(item);
        }
    }
}
