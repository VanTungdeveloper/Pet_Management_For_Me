using System;
using System.Windows.Forms;
using CRUDWinFormsMVP.Views;
using System.Configuration;
using CRUDWinFormsMVP.Presenters;

namespace CRUDWinFormsMVP
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();           
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
