namespace Rpg_Decks.UserControls
{
    partial class LoadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameL = new System.Windows.Forms.Label();
            this.LBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(13, 30);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(117, 53);
            this.nameL.TabIndex = 0;
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBtn
            // 
            this.LBtn.Location = new System.Drawing.Point(13, 136);
            this.LBtn.Name = "LBtn";
            this.LBtn.Size = new System.Drawing.Size(117, 37);
            this.LBtn.TabIndex = 1;
            this.LBtn.Text = "Load";
            this.LBtn.UseVisualStyleBackColor = true;
            this.LBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBtn_MouseClick);
            // 
            // LoadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LBtn);
            this.Controls.Add(this.nameL);
            this.Name = "LoadControl";
            this.Size = new System.Drawing.Size(148, 198);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        public System.Windows.Forms.Button LBtn;
    }
}
