using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using Rpg_Decks.UserControls;
using Rpg_Decks.JsonProfiling;
using Rpg_Decks.Card_System;

namespace Rpg_Decks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GetFiles.ProfilesList = new List<RootProfile>();

            GetFiles.IdPath = new Dictionary<int, string>();
            //empty profile for clearing
            //adding empty
            emptyProfile = GetFiles.GetjsonData(@"JSON\Defualts\DefPro.json");

            
        }
 
        //On Load
        //  - gets all paths
        //  - call on Profile Spawner
        private void Form1_Load(object sender, EventArgs e)
        {
            

            FormLoadingMethod();
        }
        private void FormLoadingMethod()
        {
            //clears Profiles list
            GetFiles.ProfilesList.Clear();
            GetFiles.IdPath.Clear();
            GetFiles.IdCounter = 0;
            //registers profiles into list
            ProfileReg();
            //calls Spawner
            ProSpawn();

            ProControlU.SaveUpdateBtn.Enabled = false;
            saveUpdateTool.Enabled = false;
            SaveTool.Enabled = false;
            ProControlU.Enabled = false;

        }

        private void ProfileReg()
        {
            //calls GetPaths and make class instance
            List<string> FileStr = GetFiles.GetPath();
            foreach (string str in FileStr)
            {
                RootProfile profile = new RootProfile();
                profile = GetFiles.GetjsonData(str);
                GetFiles.ProfilesList.Add(profile);
            }
        }

        //load all Profiles from List
        //onto FlowPanel as UserControls
        private void ProSpawn()
        {
            //added clear because ummm use this method way to many times
            FlowLayout.Controls.Clear();
            int index = 0;
            foreach(RootProfile pro in GetFiles.ProfilesList)
            {
                //contructor
                LoadControl lc = new LoadControl(pro.ProfileName, index);
                lc.ParentForm = this;
                FlowLayout.Controls.Add(lc);
                index++;
            }
            NewControl nc = new NewControl();
            nc.ParentForm = this;
            FlowLayout.Controls.Add(nc);
        }
      
        public RootProfile emptyProfile = new RootProfile();

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the flow of profiles so it doesnt keep stacking and makes my life easier with programming 
            //also by stacking i mean for everytime i add a new profile to the list
            if(TabConMain.SelectedTab == tabPage1)
            {
                FormLoadingMethod();
            }
            else if(TabConMain.SelectedTab == tabPage2)
            {
                
            }
        }
        public void LoadFunction(int id)
        {
            if (TabConMain.SelectedTab != tabPage2) { Console.WriteLine("HET"); }
            else
            {
                 ProControlU.Enabled = true;
                //re-Initializing
                ProControlU.DataLoader(emptyProfile);
                //get values from list
                RootProfile TempData = GetFiles.ProfilesList[id];
                //add all values
                ProControlU.DataLoader(TempData);
                if(ProControlU.SaveUpdateBtn.Enabled != true) { ProControlU.SaveUpdateBtn.Enabled = true; }
                if (saveUpdateTool.Enabled != true) { saveUpdateTool.Enabled = true; }
                ProControlU.SaveBtn.Enabled = true;
                ProControlU.Refresh();
               
                SaveTool.Enabled = true;
            }
        }
        public void LoadFunction()
        {           
            //Initializing
            ProControlU.DataLoader(emptyProfile);
            //switch tab
            TabConMain.SelectedTab = tabPage2;
            //disables controls
            ProControlU.SaveUpdateBtn.Enabled = false;
            saveUpdateTool.Enabled = false;
            ProControlU.SaveBtn.Enabled = true;
            ProControlU.Enabled = true;
        }

        private void switchTab(TabPage tab)
        {
            TabConMain.SelectedTab = tab;
        }

        private void SaveUpdateTool_Click(object sender, EventArgs e)
        {
            GetFiles.SaveUpdateData(ProControlU.GetProfileData());
            switchTab(tabPage1);
            FormLoadingMethod();
        }
        private void SaveTool_Click(object sender, EventArgs e)
        {
            //check if user is saving in selectedTab
            if (TabConMain.SelectedTab == tabPage2) 
            {
                GetFiles.SaveData(ProControlU.GetProfileData());
            }
            switchTab(tabPage1);
            FormLoadingMethod();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Name == "SpellsForm")
            //    {
            //        IsOpen = true;
            //        break;
            //    }
            //}

            //if (IsOpen == false)
            //{
            //    SpellsForm SpellForm = new SpellsForm();
            //    SpellForm.Name = "SpellsForm";

            //  //  SpellForm.FormSelect(InventoryForm.option.Spells);

            //    SpellForm.Show();
            //}

            GetCard.spellsForm.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetCard.spellsForm.Dispose();
            Environment.Exit(-1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Copied Code from Online
        //To make form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

    
}
