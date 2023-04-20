using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDatabaseGUI
{
    //Also need a delegate for editing an item (Need types for this)
    public delegate void AddItemDel(ItemType addItemType);

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller controller = new Controller();
            MusicDatabaseForm form = new MusicDatabaseForm();
            AddItemForm addForm = new AddItemForm();

            //Should eventually populate lists in forms using BindingLists of songs, albums, etc. stored in Controller

            form.SetAddItemDel(controller.AddItemOfType);
            controller.SetAddNewItemDel(addForm.InitializeForm);


            Application.Run(form);
        }
    }
}
