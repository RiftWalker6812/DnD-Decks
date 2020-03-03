namespace Rpg_Decks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUpdateTool = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabConMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProControlU = new Rpg_Decks.UserControls.ProfileControl();
            this.menuStrip1.SuspendLayout();
            this.TabConMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(219, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTool,
            this.saveUpdateTool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveTool
            // 
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(141, 22);
            this.SaveTool.Text = "Save";
            this.SaveTool.Click += new System.EventHandler(this.SaveTool_Click);
            // 
            // saveUpdateTool
            // 
            this.saveUpdateTool.Name = "saveUpdateTool";
            this.saveUpdateTool.Size = new System.Drawing.Size(141, 22);
            this.saveUpdateTool.Text = "Save-Update";
            this.saveUpdateTool.Click += new System.EventHandler(this.SaveUpdateTool_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // TabConMain
            // 
            this.TabConMain.Controls.Add(this.tabPage1);
            this.TabConMain.Controls.Add(this.tabPage2);
            this.TabConMain.Location = new System.Drawing.Point(5, 14);
            this.TabConMain.Name = "TabConMain";
            this.TabConMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabConMain.RightToLeftLayout = true;
            this.TabConMain.SelectedIndex = 0;
            this.TabConMain.Size = new System.Drawing.Size(793, 424);
            this.TabConMain.TabIndex = 1;
            this.TabConMain.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FlowLayout);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selection Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(3, 3);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowLayout.Size = new System.Drawing.Size(779, 392);
            this.FlowLayout.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProControlU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProControlU
            // 
            this.ProControlU.AutoScroll = true;
            this.ProControlU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProControlU.Location = new System.Drawing.Point(0, 6);
            this.ProControlU.Name = "ProControlU";
            this.ProControlU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProControlU.Size = new System.Drawing.Size(775, 388);
            this.ProControlU.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TabConMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabConMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.ToolStripMenuItem SaveTool;
        public System.Windows.Forms.TabControl TabConMain;
        public System.Windows.Forms.TabPage tabPage2;
        public UserControls.ProfileControl ProControlU;
        private System.Windows.Forms.ToolStripMenuItem saveUpdateTool;
    }
}

