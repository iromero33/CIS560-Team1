using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDatabaseGUI
{
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

            form.SetAddItemDel(controller.AddItemOfType);
            controller.SetAddNewItemDel(addForm.InitializeForm);


            Application.Run(form);
        }
    }
}
