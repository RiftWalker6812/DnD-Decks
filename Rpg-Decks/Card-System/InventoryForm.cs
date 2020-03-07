using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Decks.UserControls;

namespace Rpg_Decks
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        public void FormSelect(option option)
        {
            if(option == option.Spells) { selected = option; }
            else if(option == option.Items) { selected = option; }
        }

        private option selected;
        
        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); //cleans it
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            InvLabel.Text = selected.ToString();
            if(selected == option.Spells) { SpellLoad(); }
            else if(selected == option.Items) { ItemLoad(); }
        }
        private void SpellLoad()
        {
            
        }
        private void ItemLoad()
        {

        }

        public enum option
        {
            Spells = 0, Items = 1
        };




        //Copied Code from Online
        //To make form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void InventoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //===================================================================================

       
        void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}
