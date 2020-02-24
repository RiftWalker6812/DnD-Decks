using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Decks.UserControls
{
    public partial class LoadControl : UserControl
    {
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
    }
}
