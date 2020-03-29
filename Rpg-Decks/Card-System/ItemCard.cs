using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Decks.Card_System
{
    public partial class ItemCard : UserControl
    {
        public ItemCard()
        {
            InitializeComponent();
        }

        public Item ItemVar { get; set; }
        public ItemCard(Item item)
        {
            InitializeComponent();
            ItemVar = item;
            CardName.Text = item.ItemName;
            ItType.Text = item.ItemType;

            switch(ItType.Text)
            {
                case "Item":
                    BackColor = Color.FromArgb(31, 75, 194);
                    Variable1.Text = item.DamageDice;
                    Variable2.Text = item.DamageType;
                    Variable3.Text = item.Bonus;
                    itemDescriptionBx.Text = item.ItemDescript;
                    itemDescriptionBx.Location = new Point(3, 69);
                    itemDescriptionBx.Size = new Size(194, 213);
                    break;
                case "Weapon":
                    BackColor = Color.FromArgb(238, 47, 6);
                    Variable1.Text = item.Str;
                    Variable2.Text = item.Stealth;
                    Variable3.Text = item.Ac;
                    itemDescriptionBx.Text = item.ItemDescript;
                    itemDescriptionBx.Location = new Point(3, 109);
                    itemDescriptionBx.Size = new Size(194, 173);
                    break;
                case "Armor":
                    BackColor = Color.FromArgb(12, 95, 12);
                    itemDescriptionBx.Text = item.ItemDescript;
                    itemDescriptionBx.Location = new Point(3, 109);
                    itemDescriptionBx.Size = new Size(194, 173);
                    break;
                default:
                    itemDescriptionBx.Text = "Error";
                    itemDescriptionBx.Location = new Point(3, 109);
                    itemDescriptionBx.Size = new Size(194, 173);
                    break;
            }            
        }

        private void itemDescriptionBx_DoubleClick(object sender, EventArgs e)
        {
            //adds
            if (GetCard.Form1.ProControlU.InventoryFlow.Controls.Contains(this) != true)
            {
                GetCard.Form1.ProControlU.InventoryFlow.Controls.Add(this);
            }
            //removes
            else if (GetCard.Form1.ProControlU.InventoryFlow.Controls.Contains(this) == true)
            {
                GetCard.Form1.ProControlU.InventoryFlow.Controls.Remove(this);
            }
        }
    }
}
