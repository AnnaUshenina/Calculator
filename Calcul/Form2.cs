using System;
using System.Windows.Forms;


namespace Calcul
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();
            Calculator.Sign = true;
        }   
        
        private void AddNumbers (object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    switch ((sender as Button).Name)
                    {
                        case ("Zero"):
                            ((TextBox)c).Text += Zero.Text;
                            break;
                        case ("One"):
                            ((TextBox)c).Text += One.Text;
                            break;
                        case ("Two"):
                            ((TextBox)c).Text += Two.Text;
                            break;
                        case ("Three"):
                            ((TextBox)c).Text += Three.Text;
                            break;
                        case ("Four"):
                            ((TextBox)c).Text += Four.Text;
                            break;
                        case ("Five"):
                            ((TextBox)c).Text += Five.Text;
                            break;
                        case ("Six"):
                            ((TextBox)c).Text += Six.Text;
                            break;
                        case ("Seven"):
                            ((TextBox)c).Text += Seven.Text;
                            break;
                        case ("Eight"):
                            ((TextBox)c).Text += Eight.Text;
                            break;
                        case ("Nine"):
                            ((TextBox)c).Text += Nine.Text;
                            break;
                    }
                }
            }
        }
        private void MathOperationCall(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    switch ((sender as Button).Name)
                    {
                        case ("Plus"):
                            Calculator.MathOperation('+', 1);
                            break;
                        case ("Minus"):
                            Calculator.MathOperation('-', 2);
                            break;
                        case ("Mult"):
                            Calculator.MathOperation('*', 3);
                            break;
                        case ("Divide"):
                            Calculator.MathOperation('/', 4);
                            break;
                        case ("Equals"):
                            Calculator.Equals();
                            break;
                    }
                }
            }
        }
        private void AddPoint_Click(object sender, EventArgs e)
        {
            Calculator.AddPoint();
        }
        
        private void ClsButton_Click(object sender, EventArgs e)
        {
            Calculator.ClearScreen();
        }

        private void Backspace_Click(object sender, EventArgs e) 
        {
            Calculator.Backspace();
        }

        private void SingChange_Click(object sender, EventArgs e) 
        {
            Calculator.SignChange();
        }
    }
}
