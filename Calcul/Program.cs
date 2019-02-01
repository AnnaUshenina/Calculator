using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Data
    {
        public static string Text { get; set; }
        public static float a { get; set; }
        public static float b { get; set; }
        public static int count { get; set; }
        public static bool sign { get; set; }


        public static void Calc()
        {
            switch (count)
            {
                case 1:
                    a += b;
                    Text=a.ToString();
                    break;
                case 2:
                    a -= b;
                    Text = a.ToString();
                    break;
                case 3:
                    a *= b;
                    Text = a.ToString();
                    break;
                case 4:
                    a /= b;
                    Text = a.ToString();
                    break;
                default:
                    break;
            }
        }
    }

}
