using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rpg_Decks.Card_System
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
            GetCard.ItemList = new List<Item>();
            foreach (string FilePath in Directory.GetFiles(@"JSON\Cards\ItemsHB\", "*.json"))
            {
                StreamReader reader = new StreamReader(FilePath);
                Item item = Item.FromJson(reader.ReadToEnd());
                GetCard.ItemList.Add(item);
            }
            SpawnItems();
        }
        //Spawns all item cards from the list of items
        public void SpawnItems() 
        {
            CardFlow.Controls.Clear();
            foreach (Item item in GetCard.ItemList)
            {
                ItemCard itemCard = new ItemCard(item);
                CardFlow.Controls.Add(itemCard);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            SpawnItems();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void ItemsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            NewItemForm NewItem = new NewItemForm();
            NewItem.ShowDialog();
        }
    }
}
