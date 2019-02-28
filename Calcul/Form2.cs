using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class ButtonsForm : Form
    {        
        public Calculate calculate = new Calculate();
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
            calculate.Plus();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            calculate.Minus();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            calculate.Divide();
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            calculate.Mult();
        }
        private void Result_Click(object sender, EventArgs e)
        {
            calculate.Result();
        }
        public void AddPoint_Click()
        {
            Program.firstform.InputBox.Text += ",";
        }
        
        public void ClsButton_Click()
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
            calculate.SignChange();
        }
    }
}
