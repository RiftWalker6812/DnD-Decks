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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private string labelName { get; set; }
        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
