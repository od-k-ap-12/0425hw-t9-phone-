using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace _0425hw
{
    public partial class Form1 : Form
    {
        Controller controller;
        Button[]? buttons = null;
        public Form1()
        {
            controller=new Controller(); 
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.ReplacementSearch(richTextBox1.Text);
            buttons = this.Controls.OfType<Button>().ToArray();
            controller.ButtonColorControl(buttons,e);
        }

        private void button40_Click(object sender, EventArgs e)
        {
           string[] SplitText=richTextBox1.Text.Split(new char[] { ' ',',', '\n', '.'},StringSplitOptions.RemoveEmptyEntries);
           int place = richTextBox1.Text.LastIndexOf(SplitText.Last());
           richTextBox1.Text.Remove(place, SplitText.Last().Length).Insert(place, button40.Text);

        }
    }
}