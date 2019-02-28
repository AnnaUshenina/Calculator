using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Calcul
{
    public static class Program
    {
        public static InputAndOutputForm firstform;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            firstform = new InputAndOutputForm();
            Application.Run(firstform);
        }
    }
    
   
}
