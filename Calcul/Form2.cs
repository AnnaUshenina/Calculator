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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            Data.Sign = true;
        }    
        private void AddNumbers (char number)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += number;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            AddNumbers('0');
        }
       
        private void One_Click(object sender, EventArgs e)
        {
            AddNumbers('1');            
        }

        private void Two_Click(object sender, EventArgs e)
        {
            AddNumbers('2');
        }

        private void Three_Click(object sender, EventArgs e)
        {
            AddNumbers('3');
        }

        private void Four_Click(object sender, EventArgs e)
        {
            AddNumbers('4');
        }

        private void Five_Click(object sender, EventArgs e)
        {
            AddNumbers('5');
        }

        private void Six_Click(object sender, EventArgs e)
        {
            AddNumbers('6');
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            AddNumbers('7');
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            AddNumbers('8');
        }       

        private void Nine_Click(object sender, EventArgs e)
        {
            AddNumbers('9');
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Data.A = float.Parse(Data.Text);
            Data.MathOperationNumber = 1;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.A.ToString() + "+";
            }
            Data.Sign = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Data.A = float.Parse(Data.Text);
            Data.MathOperationNumber = 2;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.A.ToString() + "-";
            }
            Data.Sign = true;
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            Data.A = float.Parse(Data.Text);
            Data.MathOperationNumber = 3;            
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.A.ToString() + "*";
            }
            Data.Sign = true;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Data.A = float.Parse(Data.Text);
            Data.MathOperationNumber = 4;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.A.ToString() + "/";
            }
            Data.Sign = true;
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += ",";
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void Equals_Click(object sender, EventArgs e) // =
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    Data.B = float.Parse(((TextBox)c).Text);
                    ((TextBox)c).Clear();
                     Data.Calc();
                    ((TextBox)c).Text=Data.Text;
                }
                if (c is Label) 
                    ((Label)c).Text = "";
            }
           
        }

        private void ClsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is Label)
                    ((Label)c).Text = "";
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                    Data.Text = "";
                }
            }
        }

        private void Backspace_Click(object sender, EventArgs e) // стиралка
        {
            int lenght = Data.Text.Length - 1;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    for (int i = 0; i < lenght; i++)
                        ((TextBox)c).Text += Data.Text[i];
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void SingChange_Click(object sender, EventArgs e) // +/-
        {
            if (Data.Sign == true)
            {
                foreach (Control c in this.Owner.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = "-" + ((TextBox)c).Text;
                        Data.Text = ((TextBox)c).Text;
                    } 
                }
                Data.Sign = false;
            }
            else
            {
                foreach (Control c in this.Owner.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = ((TextBox)c).Text.Replace("-", "");
                        Data.Text = ((TextBox)c).Text;
                    }
                }
                Data.Sign = true;
            }
        }

        
    }
}
