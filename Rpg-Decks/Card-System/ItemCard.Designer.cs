namespace Rpg_Decks.Card_System
{
    partial class ItemCard
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
            this.ItType = new System.Windows.Forms.Label();
            this.itemDescriptionBx = new System.Windows.Forms.RichTextBox();
            this.CardName = new System.Windows.Forms.Label();
            this.Variable3 = new System.Windows.Forms.Label();
            this.Variable2 = new System.Windows.Forms.Label();
            this.Variable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItType
            // 
            this.ItType.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItType.ForeColor = System.Drawing.Color.Black;
            this.ItType.Location = new System.Drawing.Point(15, 10);
            this.ItType.Name = "ItType";
            this.ItType.Size = new System.Drawing.Size(173, 17);
            this.ItType.TabIndex = 8;
            this.ItType.Text = "TypeLabel";
            this.ItType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItType.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // itemDescriptionBx
            // 
            this.itemDescriptionBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDescriptionBx.Location = new System.Drawing.Point(3, 109);
            this.itemDescriptionBx.Name = "itemDescriptionBx";
            this.itemDescriptionBx.Size = new System.Drawing.Size(194, 173);
            this.itemDescriptionBx.TabIndex = 14;
            this.itemDescriptionBx.Text = "";
            this.itemDescriptionBx.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // CardName
            // 
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardName.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.ForeColor = System.Drawing.Color.Black;
            this.CardName.Location = new System.Drawing.Point(3, 30);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(194, 35);
            this.CardName.TabIndex = 63;
            this.CardName.Text = "Name";
            this.CardName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CardName.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // Variable3
            // 
            this.Variable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Variable3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Variable3.ForeColor = System.Drawing.Color.Black;
            this.Variable3.Location = new System.Drawing.Point(153, 69);
            this.Variable3.Name = "Variable3";
            this.Variable3.Size = new System.Drawing.Size(43, 37);
            this.Variable3.TabIndex = 73;
            this.Variable3.Text = "bx3";
            this.Variable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Variable3.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // Variable2
            // 
            this.Variable2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Variable2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Variable2.ForeColor = System.Drawing.Color.Black;
            this.Variable2.Location = new System.Drawing.Point(40, 69);
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(111, 37);
            this.Variable2.TabIndex = 72;
            this.Variable2.Text = "bx2";
            this.Variable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Variable2.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // Variable1
            // 
            this.Variable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Variable1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Variable1.ForeColor = System.Drawing.Color.Black;
            this.Variable1.Location = new System.Drawing.Point(2, 69);
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(37, 37);
            this.Variable1.TabIndex = 71;
            this.Variable1.Text = "bx1";
            this.Variable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Variable1.DoubleClick += new System.EventHandler(this.itemDescriptionBx_DoubleClick);
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemDescriptionBx);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.ItType);
            this.Controls.Add(this.Variable3);
            this.Controls.Add(this.Variable2);
            this.Controls.Add(this.Variable1);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(200, 285);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItType;
        private System.Windows.Forms.RichTextBox itemDescriptionBx;
        private System.Windows.Forms.Label CardName;
        private System.Windows.Forms.Label Variable3;
        private System.Windows.Forms.Label Variable2;
        private System.Windows.Forms.Label Variable1;
    }
}
