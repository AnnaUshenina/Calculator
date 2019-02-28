using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class InputAndOutputForm : Form
    {
        public Calculate calculate = new Calculate();
        public ButtonsForm buttonsForm = new ButtonsForm(); 
        public InputAndOutputForm()
        {
            InitializeComponent();
            buttonsForm.Show();     
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
                        calculate.Plus();
                        break;
                    case 45:
                        calculate.Minus();
                        break;
                    case 42:
                        calculate.Mult();
                        break;
                    case 47:
                        calculate.Divide();
                        break;
                    case 61:                        
                        calculate.Result();
                        break;
                    case 08:
                        buttonsForm.Backspace_Click();
                        break;
                    case 67:
                        buttonsForm.ClsButton_Click();
                        break;
                    case 44:
                        buttonsForm.AddPoint_Click();
                        break;
                    case 13:
                        calculate.Result();
                        break;
                }
            }
        }
        
    }
}
