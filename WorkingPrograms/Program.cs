using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingPrograms
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// Kerem Zayim Tarafından Yapılmıştır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
