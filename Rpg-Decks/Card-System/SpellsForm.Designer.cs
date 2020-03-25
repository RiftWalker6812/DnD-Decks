namespace Rpg_Decks
{
    partial class SpellsForm
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
            this.InvLabel = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CardFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.LevelFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassFiltering = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InvLabel
            // 
            this.InvLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InvLabel.Location = new System.Drawing.Point(12, 14);
            this.InvLabel.Name = "InvLabel";
            this.InvLabel.Size = new System.Drawing.Size(220, 42);
            this.InvLabel.TabIndex = 0;
            this.InvLabel.Text = "Spells Form";
            this.InvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBtn.Location = new System.Drawing.Point(238, 12);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(67, 44);
            this.AddNewBtn.TabIndex = 1;
            this.AddNewBtn.Text = "Add New Card";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(616, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(49, 31);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CardFlow
            // 
            this.CardFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardFlow.AutoScroll = true;
            this.CardFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardFlow.Location = new System.Drawing.Point(12, 69);
            this.CardFlow.Name = "CardFlow";
            this.CardFlow.Size = new System.Drawing.Size(653, 503);
            this.CardFlow.TabIndex = 3;
            // 
            // LevelFilter
            // 
            this.LevelFilter.FormattingEnabled = true;
            this.LevelFilter.Items.AddRange(new object[] {
            "Cantrip",
            "1st-Level",
            "2nd-Level",
            "3rd-Level",
            "4th-Level",
            "5th-Level",
            "6th-Level",
            "7th-Level",
            "8th-Level",
            "9th-Level",
            "10th-Level",
            "11th-Level",
            "12th-Level",
            "13th-Level",
            "14th-Level",
            "15th-Level",
            "16th-Level",
            "17th-Level",
            "18th-Level",
            "19th-Level",
            "20th-Level"});
            this.LevelFilter.Location = new System.Drawing.Point(409, 36);
            this.LevelFilter.Name = "LevelFilter";
            this.LevelFilter.Size = new System.Drawing.Size(142, 21);
            this.LevelFilter.TabIndex = 4;
            this.LevelFilter.Text = "Cantrip";
            this.LevelFilter.DropDownClosed += new System.EventHandler(this.LevelFilter_DropDownClosed);
            this.LevelFilter.TextChanged += new System.EventHandler(this.NameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(312, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spell-Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(352, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassFiltering
            // 
            this.ClassFiltering.Location = new System.Drawing.Point(409, 14);
            this.ClassFiltering.Name = "ClassFiltering";
            this.ClassFiltering.Size = new System.Drawing.Size(86, 20);
            this.ClassFiltering.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(501, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClassFiltering_TextChanged);
            // 
            // SpellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(677, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClassFiltering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelFilter);
            this.Controls.Add(this.CardFlow);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.InvLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpellsForm";
            this.Opacity = 0.98D;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.SpellsForm_Load);
            this.Shown += new System.EventHandler(this.SpellsForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpellsForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.FlowLayoutPanel CardFlow;
        private System.Windows.Forms.ComboBox LevelFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassFiltering;
        private System.Windows.Forms.Button button1;
    }
}