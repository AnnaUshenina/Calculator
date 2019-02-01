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
       //public float a, b;
       // public int count;
        

        public Form2()
        {
            InitializeComponent();
            Data.sign = true;
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
            Data.a = float.Parse(Data.Text);
            Data.count = 1;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.a.ToString() + "+";
            }
            Data.sign = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Data.a = float.Parse(Data.Text);
           Data.count = 2;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.a.ToString() + "-";
            }
            Data.sign = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Data.a = float.Parse(Data.Text);
            Data.count = 3;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.a.ToString() + "*";
            }
            Data.sign = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Data.a = float.Parse(Data.Text);
            Data.count = 4;
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                    Data.Text = ((TextBox)c).Text;
                }
                if (c is Label)
                    ((Label)c).Text = Data.a.ToString() + "/";
            }
            Data.sign = true;
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
            foreach (Control c in this.Owner.Controls)
            {
                if (c is TextBox)
                {
                    Data.b = float.Parse(((TextBox)c).Text);
                    ((TextBox)c).Clear();
                     Data.Calc();
                    ((TextBox)c).Text=Data.Text;
                }
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
            if (Data.sign == true)
            {
                foreach (Control c in this.Owner.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = "-" + ((TextBox)c).Text;
                        Data.Text = ((TextBox)c).Text;
                    } 
                }
                Data.sign = false;
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
                Data.sign = true;
            }
        }

        //public void Calc()
        //{
        //    switch (Data.count)
        //    {
        //        case 1:
        //            Data.b = Data.a + float.Parse(Data.Text);
        //            foreach (Control c in this.Owner.Controls)
        //            {
        //                if (c is TextBox)
        //                {
        //                    ((TextBox)c).Clear();
        //                    ((TextBox)c).Text += Data.b.ToString();
        //                    Data.Text = ((TextBox)c).Text;
        //                }
        //            }
        //            break;
        //        case 2:
        //            Data.b = Data.a - float.Parse(Data.Text);
        //            foreach (Control c in this.Owner.Controls)
        //            {
        //                if (c is TextBox)
        //                {
        //                    ((TextBox)c).Clear();
        //                    ((TextBox)c).Text += Data.b.ToString();
        //                    Data.Text = ((TextBox)c).Text;
        //                }
        //            }
        //            break;
        //        case 3:
        //            Data.b = Data.a * float.Parse(Data.Text);
        //            foreach (Control c in this.Owner.Controls)
        //            {
        //                if (c is TextBox)
        //                {
        //                    ((TextBox)c).Clear();
        //                    ((TextBox)c).Text += Data.b.ToString();
        //                    Data.Text = ((TextBox)c).Text;
        //                }
        //            }
        //            break;
        //        case 4:
        //            Data.b = Data.a / float.Parse(Data.Text);
        //            foreach (Control c in this.Owner.Controls)
        //            {
        //                if (c is TextBox)
        //                {
        //                    ((TextBox)c).Clear();
        //                    ((TextBox)c).Text += Data.b.ToString();
        //                    Data.Text = ((TextBox)c).Text;
        //                }
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
