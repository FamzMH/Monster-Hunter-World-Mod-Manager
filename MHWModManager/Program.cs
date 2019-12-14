using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWModManager
{
    static class Program
    {
        
        // TODO: Add support for mod urls (maybe IDs as well)
        // TODO: List currently added mods (store them somewhere)
        // TODO: Basic mod management (add, remove)
        // TODO: Advanced mod management (install, update, uninstall)
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ModsForm());
        }
    }
}