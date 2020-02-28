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
using System.Globalization;

namespace Rpg_Decks.UserControls
{
    public partial class LoadControl : UserControl
    {
        //Form ParentForm = Parent as Form;
        public Form1 ParentForm { get; set; }

        public LoadControl()
        {
            InitializeComponent();
        }
        public LoadControl(string str, int id)
        {
            InitializeComponent();
            name = str;
            nameL.Text = name; //names label on control
            Id = id;
        }
        public string name { get; set; }
        public int Id { get; set; }
           

        private void LBtn_MouseClick(object sender, MouseEventArgs e)
        {
           if(ParentForm == null) { return; }

            TabControl tab = (ParentForm.Controls["TabConMain"] as TabControl);
            tab.SelectedIndex = 1;

            ParentForm.LoadFunction(Id);
        }

       
    }
}
