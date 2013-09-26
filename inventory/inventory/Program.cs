using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace inventory
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada ....
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

          
        }
    }
}
