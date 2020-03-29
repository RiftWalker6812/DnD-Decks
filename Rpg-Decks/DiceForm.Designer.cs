namespace Rpg_Decks
{
    partial class DiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Half = new System.Windows.Forms.Label();
            this.Dsix = new System.Windows.Forms.Label();
            this.Deight = new System.Windows.Forms.Label();
            this.Dtwenty = new System.Windows.Forms.Label();
            this.Dtwelve = new System.Windows.Forms.Label();
            this.Dten = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Label();
            this.Dfour = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(764, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(115, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 44);
            this.label7.TabIndex = 42;
            this.label7.Text = "Dice Rolling";
            // 
            // InputLabel
            // 
            this.InputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputLabel.Location = new System.Drawing.Point(86, 99);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(255, 39);
            this.InputLabel.TabIndex = 44;
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputLabel.Location = new System.Drawing.Point(86, 138);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(255, 39);
            this.OutputLabel.TabIndex = 45;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Half
            // 
            this.Half.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Half.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Half.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Half.Location = new System.Drawing.Point(377, 217);
            this.Half.Name = "Half";
            this.Half.Size = new System.Drawing.Size(63, 38);
            this.Half.TabIndex = 48;
            this.Half.Text = "Half";
            this.Half.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Half.Visible = false;
            this.Half.Click += new System.EventHandler(this.Half_Click);
            // 
            // Dsix
            // 
            this.Dsix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dsix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dsix.Image = global::Rpg_Decks.Properties.Resources.d6;
            this.Dsix.Location = new System.Drawing.Point(173, 187);
            this.Dsix.Name = "Dsix";
            this.Dsix.Size = new System.Drawing.Size(81, 81);
            this.Dsix.TabIndex = 50;
            this.Dsix.Text = "d6";
            this.Dsix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dsix.Click += new System.EventHandler(this.Dsix_Click);
            // 
            // Deight
            // 
            this.Deight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Deight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Deight.Image = global::Rpg_Decks.Properties.Resources._8;
            this.Deight.Location = new System.Drawing.Point(260, 187);
            this.Deight.Name = "Deight";
            this.Deight.Size = new System.Drawing.Size(81, 81);
            this.Deight.TabIndex = 51;
            this.Deight.Text = "d8";
            this.Deight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deight.Click += new System.EventHandler(this.Deight_Click);
            // 
            // Dtwenty
            // 
            this.Dtwenty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtwenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtwenty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dtwenty.Image = global::Rpg_Decks.Properties.Resources._20;
            this.Dtwenty.Location = new System.Drawing.Point(260, 285);
            this.Dtwenty.Name = "Dtwenty";
            this.Dtwenty.Size = new System.Drawing.Size(81, 81);
            this.Dtwenty.TabIndex = 55;
            this.Dtwenty.Text = "d20";
            this.Dtwenty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dtwenty.Click += new System.EventHandler(this.Dtwenty_Click);
            // 
            // Dtwelve
            // 
            this.Dtwelve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtwelve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtwelve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dtwelve.Image = global::Rpg_Decks.Properties.Resources.d12;
            this.Dtwelve.Location = new System.Drawing.Point(173, 285);
            this.Dtwelve.Name = "Dtwelve";
            this.Dtwelve.Size = new System.Drawing.Size(81, 81);
            this.Dtwelve.TabIndex = 54;
            this.Dtwelve.Text = "d12";
            this.Dtwelve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dtwelve.Click += new System.EventHandler(this.Dtwelve_Click);
            // 
            // Dten
            // 
            this.Dten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dten.Image = global::Rpg_Decks.Properties.Resources.d10;
            this.Dten.Location = new System.Drawing.Point(86, 285);
            this.Dten.Name = "Dten";
            this.Dten.Size = new System.Drawing.Size(81, 81);
            this.Dten.TabIndex = 53;
            this.Dten.Text = "d10";
            this.Dten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dten.Click += new System.EventHandler(this.Dten_Click);
            // 
            // Calculate
            // 
            this.Calculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calculate.Location = new System.Drawing.Point(377, 238);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(63, 39);
            this.Calculate.TabIndex = 68;
            this.Calculate.Text = "=";
            this.Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Dfour
            // 
            this.Dfour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dfour.Image = global::Rpg_Decks.Properties.Resources.d4;
            this.Dfour.Location = new System.Drawing.Point(86, 187);
            this.Dfour.Name = "Dfour";
            this.Dfour.Size = new System.Drawing.Size(81, 81);
            this.Dfour.TabIndex = 46;
            this.Dfour.Text = "d4";
            this.Dfour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dfour.Click += new System.EventHandler(this.Dfour_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearBtn.Location = new System.Drawing.Point(377, 187);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(63, 38);
            this.ClearBtn.TabIndex = 69;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.SystemColors.Window;
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 25;
            this.Results.Location = new System.Drawing.Point(488, 111);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(207, 229);
            this.Results.TabIndex = 70;
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Dtwenty);
            this.Controls.Add(this.Dtwelve);
            this.Controls.Add(this.Dten);
            this.Controls.Add(this.Deight);
            this.Controls.Add(this.Dsix);
            this.Controls.Add(this.Half);
            this.Controls.Add(this.Dfour);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiceForm";
            this.Opacity = 0.96D;
            this.Text = "DiceForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiceForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label Dfour;
        private System.Windows.Forms.Label Half;
        private System.Windows.Forms.Label Dsix;
        private System.Windows.Forms.Label Deight;
        private System.Windows.Forms.Label Dtwenty;
        private System.Windows.Forms.Label Dtwelve;
        private System.Windows.Forms.Label Dten;
        private System.Windows.Forms.Label Calculate;
        private System.Windows.Forms.Label ClearBtn;
        private System.Windows.Forms.ListBox Results;
    }
}