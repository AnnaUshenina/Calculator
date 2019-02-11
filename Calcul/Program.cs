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
    public static class Data
    {
        public static string Text { get; set; }
        public static float A { get; set; }
        public static float B { get; set; }
        public static int MathOperationNumber { get; set; }
        public static bool Sign { get; set; }


        public static void Calc()
        {
            switch (MathOperationNumber)
            {
                case 1:
                    A += B;
                    Text=A.ToString();
                    break;
                case 2:
                    A -= B;
                    Text = A.ToString();
                    break;
                case 3:
                    A *= B;
                    Text = A.ToString();
                    break;
                case 4:
                    A /= B;
                    Text = A.ToString();
                    break;
            }
        }
    }

}
