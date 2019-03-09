using System;
using System.Windows.Forms;

namespace Calcul
{
    public partial class ButtonsForm : Form
    {        
        public Calculate calculate = new Calculate();
        public Interface Interface = new Interface();
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
            Interface.Clean(Interface.NumbericBox.Text);
            Interface.NumbericLabel.Text = calculate.A;
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            calculate.Minus();
            Interface.NumbericLabel.Text = calculate.A;
            Interface.NumbericBox.Text = "";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            calculate.Divide();
            Interface.NumbericLabel.Text = calculate.A;
            Interface.NumbericBox.Text = "";
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            calculate.Mult();
            Interface.NumbericLabel.Text = calculate.A;
            Interface.NumbericBox.Text = "";
        }
        private void Result_Click(object sender, EventArgs e)
        {
            var result = calculate.Result();
        }
        public void AddPoint_Click(object sender, EventArgs e)
        {
            Interface.NumbericBox.Text += ",";
        }
        
        public void ClsButton_Click(object sender, EventArgs e)
        {
            Interface.NumbericBox.Text = "";
            Interface.NumbericLabel.Text = "";
        }
        public void Backspace_Click(object sender, EventArgs e) 
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
