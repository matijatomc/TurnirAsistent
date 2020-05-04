using AsistentGUI.Forme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistentGUI
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

            // Zapocni spajanje na bazu podataka
            TurnirAistentModel.GlobalConfig.ZapoceteKonekcije(true, true);
            Application.Run(new KreiranjeNagrade());
        }
    }
}
