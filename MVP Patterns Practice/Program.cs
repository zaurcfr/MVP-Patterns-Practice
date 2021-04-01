using MVP_Patterns_Practice.Presenters;
using MVP_Patterns_Practice.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Patterns_Practice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new MainView();
            var presenter = new MainViewPresenter(view);
            Application.Run(view);
        }
    }
}
