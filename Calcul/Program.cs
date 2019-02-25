using System;

using System.Windows.Forms;


namespace Calcul
{
    public static class Program
    {
        public static InputAndOutputForm firstform = new InputAndOutputForm();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(firstform);
        }
    }
    
    public static class Calculator
    {
        public static float A { get; set; }
        public static float B { get; set; }
        

        public static void Plus()
        {
           // A = float.Parse(Program.firstform.InputBox.Text); 
            Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "+";
            Program.firstform.InputBox.Clear();
        }
        public static void Minus()
        {
            A = float.Parse(Program.firstform.InputBox.Text);
            Program.firstform.firstNumberLabel.Text = A.ToString() + "-";
            Program.firstform.InputBox.Clear();
        }
        public static void Divide()
        {
            A = float.Parse(Program.firstform.InputBox.Text);
            Program.firstform.firstNumberLabel.Text = A.ToString() + "/";
            Program.firstform.InputBox.Clear();
        }
        public static void Mult()
        {
            A = float.Parse(Program.firstform.InputBox.Text);
            Program.firstform.firstNumberLabel.Text = A.ToString() + "*";
            Program.firstform.InputBox.Clear();
        }
             
        public static void AddPoint()
        {
            Program.firstform.InputBox.Text += ",";
        }

        public static void SignChange()
        {
            string numberB = Program.firstform.firstNumberLabel.Text;
            if (numberB[0] !='-')
            {
                Program.firstform.InputBox.Text = "-" + Program.firstform.InputBox.Text;
            }
            else
            {
                Program.firstform.InputBox.Text = Program.firstform.InputBox.Text.Replace("-", "");
            }
        }      
        
        public static void Result()
        {
            string stringA = Program.firstform.InputBox.Text;
            char operation = stringA[stringA.Length - 1];
            stringA = stringA.Remove(stringA.Length - 1);
            A = float.Parse(stringA);
            B = float.Parse(Program.firstform.InputBox.Text);
            Program.firstform.InputBox.Clear();
            switch (operation)
            {
                case ('+'):
                    A += B;
                    break;
                case ('-'):
                    A -= B;
                    break;
                case ('*'):
                    A *= B;
                    break;
                case ('/'):
                    A /= B;
                    break;
            }
            Program.firstform.InputBox.Text = A.ToString();
            Program.firstform.firstNumberLabel.Text = "";
        }
    }

}
