using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5semestr
{
    static class Program
    {
        public static formMenu formStart;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formStart = new formMenu();
            Application.Run(formStart);
        }
    }
}
