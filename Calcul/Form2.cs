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
        float a, b;
        int count;
        bool sign = true;

        public Form2()
        {
            InitializeComponent();            
        }    
   
        private void button20_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 0;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 1;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 2;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 3;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 4;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 5;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 6;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 7;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 8;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }       

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text += 9;
                    Data.Text = ((TextBox)c).Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(Data.Text);
            count = 1;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = a.ToString() + "+";
            }
            sign = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = float.Parse(Data.Text);
            count = 2;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = a.ToString() + "-";
            }
            sign = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(Data.Text);
            count = 3;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = a.ToString() + "*";
            }
            sign = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(Data.Text);
            count = 4;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = a.ToString() + "/";
            }
            sign = true;
        }

        private void button17_Click(object sender, EventArgs e)
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

        private void button19_Click(object sender, EventArgs e) // =
        {
            Calc();
            foreach (Control c in this.Owner.Controls)
            {
                if (c is Label) 
                    ((Label)c).Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e) // стиралка
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

        private void button3_Click(object sender, EventArgs e) // +/-
        {
            if (sign == true)
            {
                foreach (Control c in this.Owner.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = "-" + ((TextBox)c).Text;
                        Data.Text = ((TextBox)c).Text;
                    }            
                    

                }
                sign = false;
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
                sign = true;
            }
        }

        public void Calc()
        {
            switch(count)
            {
                case 1:
                    b = a + float.Parse(Data.Text);
                    foreach (Control c in this.Owner.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                            ((TextBox)c).Text += b.ToString();
                            Data.Text = ((TextBox)c).Text;
                        }
                    }
                    break;
                case 2:
                    b = a - float.Parse(Data.Text);
                    foreach (Control c in this.Owner.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                            ((TextBox)c).Text += b.ToString();
                            Data.Text = ((TextBox)c).Text;
                        }
                    }
                    break;
                case 3:
                    b = a * float.Parse(Data.Text);
                    foreach (Control c in this.Owner.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                            ((TextBox)c).Text += b.ToString();
                            Data.Text = ((TextBox)c).Text;
                        }
                    }
                    break;
                case 4:
                    b = a / float.Parse(Data.Text);
                    foreach (Control c in this.Owner.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                            ((TextBox)c).Text += b.ToString();
                            Data.Text = ((TextBox)c).Text;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
