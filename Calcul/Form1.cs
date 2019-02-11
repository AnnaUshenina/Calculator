using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
               e.Handled = true;
               Data.Text += textBox1.Text;
            }
            if (e.KeyChar == 43)
            {
                Data.MathOperationNumber = 1;
                Data.A = float.Parse(textBox1.Text);
                textBox1.Clear();
                label1.Text = Data.A.ToString() + "+";
                Data.Sign = true;
            }
            if (e.KeyChar == 45)
            {
                Data.MathOperationNumber = 2;
                Data.A = float.Parse(textBox1.Text);
                textBox1.Clear();
                label1.Text = Data.A.ToString() + "-";
                Data.Sign = true;
            }
            if (e.KeyChar == 42)
            {
                Data.MathOperationNumber = 3;
                Data.A = float.Parse(textBox1.Text);
                textBox1.Clear();
                label1.Text = Data.A.ToString() + "*";
                Data.Sign = true;
            }
            if (e.KeyChar == 47)
            {
                Data.MathOperationNumber = 4;
                Data.A = float.Parse(textBox1.Text);
                textBox1.Clear();
                label1.Text = Data.A.ToString() + "/";
                Data.Sign = true;
            }
            if (e.KeyChar == 61) // =
            {
                Data.B = float.Parse(textBox1.Text);
                textBox1.Clear();
                Data.Calc();
                textBox1.Text = Data.Text;                      
                label1.Text = "";
            }
            if (e.KeyChar == 08) // backspace
            {
                int lenght = textBox1.Text.Length - 1;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                    textBox1.Text += Data.Text[i];
                Data.Text = textBox1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           ////////
        }

    }
}
