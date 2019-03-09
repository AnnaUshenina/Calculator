using System.Windows.Forms;


namespace Calcul
{
    
    public class Calculate
    {
        public string A;
        public string B;
        public Interface Interface = new Interface();

        private bool IsEmpty (string str)
        {
            if (str == "")
                return true;
            return false;

        }
        public  void Plus()
        {
            
             if (!IsEmpty(Interface.NumbericBox.Text) || !IsEmpty(Interface.NumbericBox.Text))
                A = Interface.NumbericBox.Text + "+";
             
        }
        public void Minus()
        {
            if (!IsEmpty(Interface.NumbericLabel.Text) || !IsEmpty(Interface.NumbericBox.Text))
            {
                A = Interface.NumbericBox.Text + "-";
            }
        }
        public  void Divide()
        {
            if (!IsEmpty(Interface.NumbericLabel.Text) || !IsEmpty(Interface.NumbericBox.Text))
            {
                A = Interface.NumbericBox.Text + "/";
            }
        }
        public  void Mult()
        {
            if (!IsEmpty(Interface.NumbericLabel.Text) || !IsEmpty(Interface.NumbericBox.Text))
            {
                A = Interface.NumbericBox.Text + "*";
            }
        }
        public  void SignChange()
        {
            if (!IsEmpty(Interface.NumbericLabel.Text) || !IsEmpty(Interface.NumbericBox.Text))
            {
                string numberB = Interface.NumbericBox.Text;
                if (numberB[0] != '-')
                {
                    Program.firstform.InputBox.Text = "-" + Program.firstform.InputBox.Text;
                }
                else
                {
                    Program.firstform.InputBox.Text = Program.firstform.InputBox.Text.Replace("-", "");
                }
            }
        }

        public float Result()
        {
            float result=0;
            string stringA = Program.firstform.firstNumberLabel.Text;
            string stringB = Program.firstform.InputBox.Text;
            if (!IsEmpty(stringA) || !IsEmpty(stringB))
            {
                char operation = stringA[stringA.Length - 1];
                stringA = stringA.Remove(stringA.Length - 1);
                A = float.Parse(stringA);
                B = float.Parse(stringB);
                switch (operation)
                {
                    case ('+'):
                        result = A + B;
                        break;
                    case ('-'):
                        result = A - B;
                        break;
                    case ('*'):
                        result = A * B;
                        break;
                    case ('/'):
                       result = A / B;
                        break;
                }
            }
            return result;
        }
    }
}
