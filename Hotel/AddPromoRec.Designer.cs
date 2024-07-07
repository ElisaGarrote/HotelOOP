namespace Hotel
{
    partial class AddPromoRec
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
            this.addrecPromo_btn = new System.Windows.Forms.Button();
            this.roomDes_field = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.applyRoom_picker = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.promoEnd_picker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.promoStart_picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.promoPrice_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.promoName_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.addrecPromo_btn);
            this.panel1.Controls.Add(this.roomDes_field);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.applyRoom_picker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.promoEnd_picker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.promoStart_picker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.promoPrice_field);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.promoName_field);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 351);
            this.panel1.TabIndex = 0;
            // 
            // addrecPromo_btn
            // 
            this.addrecPromo_btn.BackColor = System.Drawing.Color.Yellow;
            this.addrecPromo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.addrecPromo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addrecPromo_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrecPromo_btn.Location = new System.Drawing.Point(638, 306);
            this.addrecPromo_btn.Name = "addrecPromo_btn";
            this.addrecPromo_btn.Size = new System.Drawing.Size(123, 31);
            this.addrecPromo_btn.TabIndex = 11;
            this.addrecPromo_btn.Text = "Add";
            this.addrecPromo_btn.UseVisualStyleBackColor = false;
            // 
            // roomDes_field
            // 
            this.roomDes_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomDes_field.Location = new System.Drawing.Point(471, 31);
            this.roomDes_field.Multiline = true;
            this.roomDes_field.Name = "roomDes_field";
            this.roomDes_field.Size = new System.Drawing.Size(283, 194);
            this.roomDes_field.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Promotion Description:";
            // 
            // applyRoom_picker
            // 
            this.applyRoom_picker.Location = new System.Drawing.Point(121, 205);
            this.applyRoom_picker.Name = "applyRoom_picker";
            this.applyRoom_picker.Size = new System.Drawing.Size(150, 20);
            this.applyRoom_picker.TabIndex = 8;
            this.applyRoom_picker.Text = "domainUpDown1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Applicable Room:";
            // 
            // promoEnd_picker
            // 
            this.promoEnd_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.promoEnd_picker.Location = new System.Drawing.Point(122, 163);
            this.promoEnd_picker.Name = "promoEnd_picker";
            this.promoEnd_picker.Size = new System.Drawing.Size(150, 20);
            this.promoEnd_picker.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "End Date:";
            // 
            // promoStart_picker
            // 
            this.promoStart_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.promoStart_picker.Location = new System.Drawing.Point(122, 120);
            this.promoStart_picker.Name = "promoStart_picker";
            this.promoStart_picker.Size = new System.Drawing.Size(150, 20);
            this.promoStart_picker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date:";
            // 
            // promoPrice_field
            // 
            this.promoPrice_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promoPrice_field.Location = new System.Drawing.Point(122, 77);
            this.promoPrice_field.Name = "promoPrice_field";
            this.promoPrice_field.Size = new System.Drawing.Size(150, 20);
            this.promoPrice_field.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Price:";
            // 
            // promoName_field
            // 
            this.promoName_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promoName_field.Location = new System.Drawing.Point(122, 32);
            this.promoName_field.Name = "promoName_field";
            this.promoName_field.Size = new System.Drawing.Size(150, 20);
            this.promoName_field.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promotion Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Promotion";
            // 
            // AddPromoRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddPromoRec";
            this.Text = "AddPromoAd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox promoPrice_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox promoName_field;
        private System.Windows.Forms.Button addrecPromo_btn;
        private System.Windows.Forms.TextBox roomDes_field;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DomainUpDown applyRoom_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker promoEnd_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker promoStart_picker;
    }
}