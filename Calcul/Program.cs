using System;

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
    
    public static class Calculator
    {
        public static float A { get; set; }
        public static float B { get; set; }
        public static int MathOperationNumber { get; set; }
        public static bool Sign { get; set; }

        public static Form1 form = (Form1)Application.OpenForms["Form1"];
        
        public static void MathOperation(char operation, int number)
        {
            MathOperationNumber = number;
            A = float.Parse(form.textBox1.Text);
            form.textBox1.Clear();
            form.label1.Text = A.ToString() + operation;
            Sign = true;
        }
        
        public static void ClearScreen ()
        {
           form.label1.Text = "";
           form.textBox1.Text = "";      
        }
        public static void AddPoint()
        {
            form.textBox1.Text += ",";
        }

        public static void SignChange()
        {
            if (Sign)
            {
                form.textBox1.Text = "-" + form.textBox1.Text;
                Sign = !Sign;
            }
            else
            {
                form.textBox1.Text = form.textBox1.Text.Replace("-", "");
                Sign = !Sign;
            }
        }
        public static void Backspace ()
        {
            int lenght = form.textBox1.Text.Length - 1;
            string bufferText = form.textBox1.Text;
            form.textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                form.textBox1.Text += bufferText[i];
        }
        
        public static void Result()
        {           
            B = float.Parse(form.textBox1.Text);
            form.textBox1.Clear();
            switch (MathOperationNumber)
            {
                case 1:
                    A += B;
                    break;
                case 2:
                    A -= B;
                    break;
                case 3:
                    A *= B;
                    break;
                case 4:
                    A /= B;
                    break;
            }
            form.textBox1.Text = A.ToString();
            form.label1.Text = "";
        }
    }

}
