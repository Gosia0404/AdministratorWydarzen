using AdministratorWydarzen.Views;
using AdministratorWydarzen.Models;
using AdministratorWydarzen.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministratorWydarzen.Views;

namespace AdministratorWydarzen
{
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

            IWydarzenieView view = new Form1();
            IWydarzenieRepository repository = new WydarzenieRepository();
            new WydarzeniePresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}