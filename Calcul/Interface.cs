using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public class Interface
    {
        public Label NumbericLabel;
        public TextBox NumbericBox;

        public Interface()
        {
            NumbericLabel = Program.firstform.firstNumberLabel;
            NumbericBox = Program.firstform.InputBox;
        }
        public void Clean(string str)
        {
            str = "";
        }
    }
}
