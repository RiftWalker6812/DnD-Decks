﻿namespace Rpg_Decks
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
            this.toolStripMenuItemsBook = new System.Windows.Forms.ToolStripMenuItem();
            this.newSpellCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabConMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProControlU = new Rpg_Decks.UserControls.ProfileControl();
            this.label1 = new System.Windows.Forms.Label();
            this.newItemCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Location = new System.Drawing.Point(9, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTool,
            this.saveUpdateTool});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveTool
            // 
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(180, 22);
            this.SaveTool.Text = "Save";
            this.SaveTool.Click += new System.EventHandler(this.SaveTool_Click);
            // 
            // saveUpdateTool
            // 
            this.saveUpdateTool.Name = "saveUpdateTool";
            this.saveUpdateTool.Size = new System.Drawing.Size(180, 22);
            this.saveUpdateTool.Text = "Save-Update";
            this.saveUpdateTool.Click += new System.EventHandler(this.SaveUpdateTool_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Enabled = false;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemsBook,
            this.newSpellCardToolStripMenuItem,
            this.newItemCardToolStripMenuItem,
            this.diceFormToolStripMenuItem});
            this.windowsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "SpellBook";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItemsBook
            // 
            this.toolStripMenuItemsBook.Name = "toolStripMenuItemsBook";
            this.toolStripMenuItemsBook.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemsBook.Text = "ItemsBook";
            this.toolStripMenuItemsBook.Click += new System.EventHandler(this.toolStripMenuItemsBook_Click);
            // 
            // newSpellCardToolStripMenuItem
            // 
            this.newSpellCardToolStripMenuItem.Name = "newSpellCardToolStripMenuItem";
            this.newSpellCardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSpellCardToolStripMenuItem.Text = "New SpellCard";
            this.newSpellCardToolStripMenuItem.Click += new System.EventHandler(this.newSpellCardToolStripMenuItem_Click);
            // 
            // diceFormToolStripMenuItem
            // 
            this.diceFormToolStripMenuItem.Name = "diceFormToolStripMenuItem";
            this.diceFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diceFormToolStripMenuItem.Text = "Dice Form";
            this.diceFormToolStripMenuItem.Click += new System.EventHandler(this.diceFormToolStripMenuItem_Click);
            // 
            // TabConMain
            // 
            this.TabConMain.Controls.Add(this.tabPage1);
            this.TabConMain.Controls.Add(this.tabPage2);
            this.TabConMain.Location = new System.Drawing.Point(5, 24);
            this.TabConMain.Name = "TabConMain";
            this.TabConMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabConMain.RightToLeftLayout = true;
            this.TabConMain.SelectedIndex = 0;
            this.TabConMain.Size = new System.Drawing.Size(1100, 629);
            this.TabConMain.TabIndex = 1;
            this.TabConMain.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.FlowLayout);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selection Tab";
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayout.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(3, 3);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlowLayout.Size = new System.Drawing.Size(1086, 597);
            this.FlowLayout.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage2.Controls.Add(this.ProControlU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile Tab";
            // 
            // ProControlU
            // 
            this.ProControlU.AutoScroll = true;
            this.ProControlU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProControlU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ProControlU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProControlU.Location = new System.Drawing.Point(0, 6);
            this.ProControlU.Name = "ProControlU";
            this.ProControlU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProControlU.Size = new System.Drawing.Size(1086, 592);
            this.ProControlU.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1081, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newItemCardToolStripMenuItem
            // 
            this.newItemCardToolStripMenuItem.Name = "newItemCardToolStripMenuItem";
            this.newItemCardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newItemCardToolStripMenuItem.Text = "New ItemCard";
            this.newItemCardToolStripMenuItem.Click += new System.EventHandler(this.newItemCardToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1112, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TabConMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabConMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemsBook;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.ToolStripMenuItem SaveTool;
        public System.Windows.Forms.TabControl TabConMain;
        public System.Windows.Forms.TabPage tabPage2;
        public UserControls.ProfileControl ProControlU;
        private System.Windows.Forms.ToolStripMenuItem saveUpdateTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newSpellCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemCardToolStripMenuItem;
    }
}

