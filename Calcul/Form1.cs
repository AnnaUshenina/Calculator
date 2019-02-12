using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            Calculator.form = this;
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            int ascii = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                switch (ascii)
                {
                    case 43:
                        Calculator.MathOperation('+', 1);
                        break;
                    case 45:
                        Calculator.MathOperation('-', 2);
                        break;
                    case 42:
                        Calculator.MathOperation('*', 3);
                        break;
                    case 47:
                        Calculator.MathOperation('/', 4);
                        break;
                    case 61:                        
                        Calculator.Result();
                        break;
                    case 08:                        
                        Calculator.Backspace();
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           ////////
        }

    }
}
