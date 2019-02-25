using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class InputAndOutputForm : Form
    {
        public ButtonsForm buttonsForm = new ButtonsForm(); 
        public InputAndOutputForm()
        {
            InitializeComponent();
            buttonsForm.ShowDialog();     
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char KeyAsciiNumber = e.KeyChar;
            if (!char.IsDigit(KeyAsciiNumber))
            {
                e.Handled = true;
                switch ((int)KeyAsciiNumber)
                {
                    case 43:
                        Calculator.Plus();
                        break;
                    case 45:
                        Calculator.Minus();
                        break;
                    case 42:
                        Calculator.Mult();
                        break;
                    case 47:
                        Calculator.Divide();
                        break;
                    case 61:                        
                        Calculator.Result();
                        break;
                    case 08:
                        buttonsForm.Backspace_Click();
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
