using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseAlphabet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void frmMain_Load(object sender, EventArgs e)
        {
            lblShowText.Text = String.Empty;
            lblShowMorse.Text = String.Empty;
        }
        public void btnTranslate_Click(object sender, EventArgs e)
        {
            lblShowText.Text = tbText.Text;
            var dictionary = new Dictionary<string, string>();
            dictionary.Add(" ", " ");
            dictionary.Add("A", ".-");
            dictionary.Add("B", "-...");
            dictionary.Add("C", "-.-.");
            dictionary.Add("D", "-..");
            dictionary.Add("E", ".");
            dictionary.Add("F", "..-.");
            dictionary.Add("G", "--.");
            dictionary.Add("H", "....");
            dictionary.Add("I", "..");
            dictionary.Add("J", ".---");
            dictionary.Add("K", "-.-");
            dictionary.Add("L", ".-..");
            dictionary.Add("M", "--");
            dictionary.Add("N", "-.");
            dictionary.Add("O", "---");
            dictionary.Add("P", ".--.");
            dictionary.Add("Q", "--.-");
            dictionary.Add("R", ".-.");
            dictionary.Add("S", "...");
            dictionary.Add("T", "-");
            dictionary.Add("U", "..-");
            dictionary.Add("V", "...-");
            dictionary.Add("W", ".--");
            dictionary.Add("X", "-..-");
            dictionary.Add("Y", "-.--");
            dictionary.Add("Z", "--..");
            dictionary.Add("1", ".----");
            dictionary.Add("2", "..---");
            dictionary.Add("3", "...--");
            dictionary.Add("4", "....-");
            dictionary.Add("5", ".....");
            dictionary.Add("6", "-....");
            dictionary.Add("7", "--...");
            dictionary.Add("8", "---..");
            dictionary.Add("9", "----.");
            dictionary.Add("0", "-----");

            string text = lblShowText.Text;

            string morse = string.Empty;

            foreach (var c in text)
            {
                morse += dictionary[c.ToString().ToUpper()] + " ";
            }

            lblShowText.Text = tbText.Text;
            lblShowMorse.Text = ($"{morse}");
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            lblShowText.Text = String.Empty;
            lblShowMorse.Text = String.Empty;
        }
    }
}
