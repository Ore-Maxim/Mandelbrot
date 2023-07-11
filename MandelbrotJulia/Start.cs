using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Start
    {
        public static Menu Menu
        {
            get => default;
            set
            {
            }
        }

        public static Mandelbrot Mandelbrot
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mandelbrot(0,0));
        }
    }
}
