using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Decks;

namespace Rpg_Decks.UserControls
{
    public partial class NewControl : UserControl
    {
        public Form1 ParentForm { get; set; }
        public NewControl()
        {
            InitializeComponent();
        }

        private void NewProfileBtn_Click(object sender, EventArgs e)
        {
            ParentForm.LoadFunction();
        }
    }
}
