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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Profile instance structer
        public struct Profile
        {
            public string Name;

        }

        //List of Profile Instances
        List<Profile> profilesList = new List<Profile>();
        //On Load
        //  - call on Profile Spawner
        private void Form1_Load(object sender, EventArgs e)
        {
            //testing Instance
            Profile profile = new Profile();
            profile.Name = "Rift";
            profilesList.Add(profile);

            //calls Spawner
            ProSpawn();

            
        }

        //load all Profiles from List
        //onto FlowPanel as UserControls
        private void ProSpawn()
        {
            int index = 0;
            foreach(Profile pro in profilesList)
            {
                LoadControl lc = new LoadControl(pro.Name, index);
                FlowLayout.Controls.Add(lc);
                index++;
            }
            NewControl nc = new NewControl();
            FlowLayout.Controls.Add(nc);
        }
    }
}
