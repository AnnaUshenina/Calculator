

namespace Calcul
{
    public class Calculate
    {
        public float A;
        public float B;
        
        public  void Plus()
        {
            if (Program.firstform.firstNumberLabel.Text != "" || Program.firstform.InputBox.Text != "")
            {
                Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "+";
                Program.firstform.InputBox.Clear();
            }
        }
        public  void Minus()
        {
            if (Program.firstform.firstNumberLabel.Text != "" || Program.firstform.InputBox.Text != "")
            {
                Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "-";
                Program.firstform.InputBox.Clear();
            }
        }
        public  void Divide()
        {
            if (Program.firstform.firstNumberLabel.Text != "" || Program.firstform.InputBox.Text != "")
            {
                Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "/";
                Program.firstform.InputBox.Clear();
            }
        }
        public  void Mult()
        {
            if (Program.firstform.firstNumberLabel.Text != "" || Program.firstform.InputBox.Text != "")
            {
                Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "*";
                Program.firstform.InputBox.Clear();
            }
        }
        public  void SignChange()
        {
            string numberB = Program.firstform.InputBox.Text;
            if (numberB[0] != '-')
            {
                Program.firstform.InputBox.Text = "-" + Program.firstform.InputBox.Text;
            }
            else
            {
                Program.firstform.InputBox.Text = Program.firstform.InputBox.Text.Replace("-", "");
            }
        }

        public void Result()
        {
            string stringA = Program.firstform.firstNumberLabel.Text;
            string stringB = Program.firstform.InputBox.Text;
            if (stringA != "" && stringB != "")
            {
                char operation = stringA[stringA.Length - 1];
                stringA = stringA.Remove(stringA.Length - 1);
                A = float.Parse(stringA);
                B = float.Parse(stringB);
                Program.firstform.InputBox.Clear();
                switch (operation)
                {
                    case ('+'):
                        A += B;
                        break;
                    case ('-'):
                        A -= B;
                        break;
                    case ('*'):
                        A *= B;
                        break;
                    case ('/'):
                        A /= B;
                        break;
                }
                Program.firstform.InputBox.Text = A.ToString();
                Program.firstform.firstNumberLabel.Text = "";
            }
        }
    }
}
