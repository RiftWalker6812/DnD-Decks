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
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        //custom event handler for additions to the card
        private void Additions(object sender, EventArgs e)
        {
            switch(AddType.Text)
            {
                case "Weapon":
                    VarL1.Text = "Damage Dice";
                    VarL2.Text = "Damage Type";
                    VarL3.Text = "Attack Bonus";
                    VarL1.Visible = true;
                    VarL2.Visible = true;
                    VarL3.Visible = true;
                    AddV1.Visible = true;
                    AddV2.Visible = true;
                    AddV3.Visible = true;
                    itemDescriptionBx.Location = new Point(11, 109);
                    itemDescriptionBx.Size = new Size(194, 173);
                    break;
                case "Armor":
                    VarL1.Text = "Strenght";
                    VarL2.Text = "Stealth";
                    VarL3.Text = "Armor Class";
                    VarL1.Visible = true;
                    VarL2.Visible = true;
                    VarL3.Visible = true;
                    AddV1.Visible = true;
                    AddV2.Visible = true;
                    AddV3.Visible = true;
                    itemDescriptionBx.Location = new Point(11, 109);
                    itemDescriptionBx.Size = new Size(194, 173);
                    break;
                case "Item":
                    VarL1.Text = "";
                    VarL2.Text = "";
                    VarL3.Text = "";
                    VarL1.Visible = false;
                    VarL2.Visible = false;
                    VarL3.Visible = false;
                    AddV1.Visible = false;
                    AddV2.Visible = false;
                    AddV3.Visible = false;
                    itemDescriptionBx.Location = new Point(11, 69);
                    itemDescriptionBx.Size = new Size(194, 206);
                    break;
                default:
                    break;
            }
            ExProp();
        }
        private void ExProp()
        {
            CardName.Text = AddName.Text;
            ItType.Text = AddType.Text;

            switch (ItType.Text)
            {
                case "Item":
                    CardPanel.BackColor = Color.FromArgb(31, 75, 194);
                    Variable1.Text = AddV1.Text;
                    Variable2.Text = AddV2.Text;
                    Variable3.Text = AddV3.Text;
                    itemDescriptionBx.Text = AddDescript.Text;
                    break;
                case "Weapon":
                    CardPanel.BackColor = Color.FromArgb(238, 47, 6);
                    Variable1.Text = AddV1.Text;
                    Variable2.Text = AddV2.Text;
                    Variable3.Text = AddV3.Text;
                    itemDescriptionBx.Text = AddDescript.Text;
                    break;
                case "Armor":
                    CardPanel.BackColor = Color.FromArgb(12, 95, 12);
                    itemDescriptionBx.Text = AddDescript.Text;
                    break;
                default:
                    itemDescriptionBx.Text = "Error";
                    break;
            }
            //fixs bug!
            Variable1.BackColor = Color.White;
            Variable2.BackColor = Color.White;
            Variable3.BackColor = Color.White;
            CardName.BackColor = Color.White;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Item ItemVariable = new Item();
            //Item Properties
            ItemVariable.ItemType = AddType.SelectedItem.ToString();
            ItemVariable.ItemName = AddName.Text;
            ItemVariable.ItemDescript = AddDescript.Text;
            switch(AddType.Text)
            {
                case "Item":
                   
                    break;
                case "Weapon":
                    ItemVariable.DamageDice = AddV1.Text;
                    ItemVariable.DamageType = AddV2.Text;
                    ItemVariable.Bonus = AddV3.Text;
                    break;
                case "Armor":
                    ItemVariable.Str = AddV1.Text;
                    ItemVariable.Stealth = AddV2.Text;
                    ItemVariable.Ac = AddV3.Text;
                    break;
                default:                    
                    break;
            }              
            //adds object Item
            GetCard.ItemList.Add(ItemVariable);
            GetCard.ItemsForm.SpawnItems();
            //IO Stream Item Object
            string JItem = ItemVariable.ToJson();
            StreamWriter writer = new StreamWriter($@"JSON\Cards\ItemsHB\{ItemVariable.ItemName}.json");
            writer.Write(JItem);
            writer.Close();
            Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();    
        private void NewItemForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
