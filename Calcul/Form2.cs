using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class ButtonsForm : Form
    {        
        public ButtonsForm()
        {
            InitializeComponent();
        }   
        
        private void AddNumbers (object sender, EventArgs e)
        {
            Button NumberButton = sender as Button;
            Program.firstform.InputBox.Text += NumberButton.Text;
           
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            Calculator.Plus();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            Calculator.Minus();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            Calculator.Divide();
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            Calculator.Mult();
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            Calculator.Result();
        }
        private void AddPoint_Click(object sender, EventArgs e)
        {
            Calculator.AddPoint();
        }
        
        private void ClsButton_Click(object sender, EventArgs e)
        {
            Program.firstform.firstNumberLabel.Text = "";
            Program.firstform.InputBox.Text = "";
        }

        public void Backspace_Click() 
        {
            int lenght = Program.firstform.InputBox.Text.Length - 1;
            string bufferText = Program.firstform.InputBox.Text;
            Program.firstform.InputBox.Clear();
            for (int i = 0; i < lenght; i++)
                Program.firstform.InputBox.Text += bufferText[i];
        }

        private void SingChange_Click(object sender, EventArgs e) 
        {
            Calculator.SignChange();
        }
    }
}
