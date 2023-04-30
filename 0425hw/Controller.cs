using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0425hw
{
    internal class Controller
    {
        Model model=new Model();
        public string ReplacementSearch(string Text)
        {
            string Word = Text.Split(new char[] { ' ', ',', '\n', '.' }, StringSplitOptions.RemoveEmptyEntries).Last();
            return model.ParseDictionary(Word);
        }
        public void ButtonColorControl(Button[] buttons, KeyPressEventArgs e)
        {
            foreach (Button button in buttons)
            {
                if (button.Text == Convert.ToString(e.KeyChar) || button.Text.ToLower() == Convert.ToString(e.KeyChar))
                {
                    button.BackColor = Color.Coral;
                }
                else
                {
                    button.BackColor = Color.Gray;
                }
            }
        }
    }
}
