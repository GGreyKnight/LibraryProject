using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka;

namespace LibraryProject
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionString.setConnectionString(@"Data Source=.\libraryDB.db;Version=3");
            Application.Run(new MenuForm());
        }
    }
}
