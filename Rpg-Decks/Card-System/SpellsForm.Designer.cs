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
            // SpellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(677, 584);
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

        }

        #endregion

        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.FlowLayoutPanel CardFlow;
    }
}