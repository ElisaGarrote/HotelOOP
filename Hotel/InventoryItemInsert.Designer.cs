namespace Hotel
{
    partial class InventoryItemInsert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.itemnum_btn = new System.Windows.Forms.TextBox();
            this.itemType_btn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemName_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPrice_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemAdded_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity_field = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.quantity_field);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.itemAdded_btn);
            this.panel1.Controls.Add(this.itemPrice_field);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.itemName_field);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.itemType_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.itemnum_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 240);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Number:";
            // 
            // itemnum_btn
            // 
            this.itemnum_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemnum_btn.Location = new System.Drawing.Point(96, 27);
            this.itemnum_btn.Name = "itemnum_btn";
            this.itemnum_btn.Size = new System.Drawing.Size(131, 20);
            this.itemnum_btn.TabIndex = 1;
            this.itemnum_btn.TextChanged += new System.EventHandler(this.itemnum_btn_TextChanged);
            // 
            // itemType_btn
            // 
            this.itemType_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemType_btn.Location = new System.Drawing.Point(96, 72);
            this.itemType_btn.Name = "itemType_btn";
            this.itemType_btn.Size = new System.Drawing.Size(131, 20);
            this.itemType_btn.TabIndex = 3;
            this.itemType_btn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemName_field
            // 
            this.itemName_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemName_field.Location = new System.Drawing.Point(96, 114);
            this.itemName_field.Name = "itemName_field";
            this.itemName_field.Size = new System.Drawing.Size(131, 20);
            this.itemName_field.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name:";
            // 
            // itemPrice_field
            // 
            this.itemPrice_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPrice_field.Location = new System.Drawing.Point(96, 158);
            this.itemPrice_field.Name = "itemPrice_field";
            this.itemPrice_field.Size = new System.Drawing.Size(131, 20);
            this.itemPrice_field.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Price:";
            // 
            // itemAdded_btn
            // 
            this.itemAdded_btn.BackColor = System.Drawing.Color.Yellow;
            this.itemAdded_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.itemAdded_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemAdded_btn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemAdded_btn.Location = new System.Drawing.Point(380, 205);
            this.itemAdded_btn.Name = "itemAdded_btn";
            this.itemAdded_btn.Size = new System.Drawing.Size(106, 26);
            this.itemAdded_btn.TabIndex = 8;
            this.itemAdded_btn.Text = "Add item";
            this.itemAdded_btn.UseVisualStyleBackColor = false;
            this.itemAdded_btn.Click += new System.EventHandler(this.itemAdded_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity:";
            // 
            // quantity_field
            // 
            this.quantity_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity_field.Location = new System.Drawing.Point(311, 27);
            this.quantity_field.Name = "quantity_field";
            this.quantity_field.Size = new System.Drawing.Size(131, 20);
            this.quantity_field.TabIndex = 10;
            // 
            // InventoryItemInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(523, 264);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "InventoryItemInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryItemInsert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox itemType_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemnum_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemPrice_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemName_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button itemAdded_btn;
        private System.Windows.Forms.TextBox quantity_field;
        private System.Windows.Forms.Label label5;
    }
}