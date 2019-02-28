

namespace Calcul
{
    public class Calculate
    {
        public  float A { get; set; }
        public  float B { get; set; }
        
        public  void Plus()
        {
            Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "+";
            Program.firstform.InputBox.Clear();
        }
        public  void Minus()
        {
            Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "-";
            Program.firstform.InputBox.Clear();
        }
        public  void Divide()
        {
            Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "/";
            Program.firstform.InputBox.Clear();
        }
        public  void Mult()
        {
            Program.firstform.firstNumberLabel.Text = Program.firstform.InputBox.Text + "*";
            Program.firstform.InputBox.Clear();
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
        public  void Result()
        {
            string stringA = Program.firstform.firstNumberLabel.Text;
            char operation = stringA[stringA.Length - 1];
            stringA = stringA.Remove(stringA.Length - 1);
            A = float.Parse(stringA);
            B = float.Parse(Program.firstform.InputBox.Text);
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
