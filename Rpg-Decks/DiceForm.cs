using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Decks
{
    public partial class DiceForm : Form
    {
        public DiceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private enum DiceType
        {
            d4 = 4,
            d6 = 6,
            d8 = 8,
            d10 = 10,
            d12 = 12,
            d20 = 20
        }

        Random rand = new Random();
        private string input;
        private string diceN;
        private int x;
        private int dice;

        private void values(DiceType value)
        {
            dice = (int)value;
            
            if (diceN == value.ToString())
            {
                x++;
                input = $"{x}{diceN}";
                InputLabel.Text = input;
            }
            else {
                diceN = value.ToString();
                x = 1;
                input = $"{x}{diceN}";
                InputLabel.Text = input;
            }
            diceN = value.ToString();
        }

        private void Dfour_Click(object sender, EventArgs e)
        {
            values(DiceType.d4);
        }

        private void Dsix_Click(object sender, EventArgs e)
        {
            values(DiceType.d6);
        }

        private void Deight_Click(object sender, EventArgs e)
        {
            values(DiceType.d8);
        }

        private void Dten_Click(object sender, EventArgs e)
        {
            values(DiceType.d10);
        }

        private void Dtwelve_Click(object sender, EventArgs e)
        {
            values(DiceType.d12);
        }

        private void Dtwenty_Click(object sender, EventArgs e)
        {
            values(DiceType.d20);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int output = 0;
            for(int y = 1; y <= x; y++)
            {
                output += rand.Next(0, dice);
                output++;
               // if(output == 0) { output++; }
            }
            OutputLabel.Text = output.ToString();
            Results.Items.Add(output.ToString() + " (" + diceN + ")");
            
        }

        private void Half_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            input = "";
            diceN = "";
            x = 0;
            dice = 0;
            InputLabel.Text = "";
            OutputLabel.Text = "";
            Results.Items.Clear();
        }

        //Copied Code from Online
        //To make form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DiceForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
