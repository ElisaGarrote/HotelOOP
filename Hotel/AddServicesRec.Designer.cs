namespace Hotel
{
    partial class AddServicesRec
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
            this.serDuration_pick = new System.Windows.Forms.DateTimePicker();
            this.addserRec_btn = new System.Windows.Forms.Button();
            this.serAvail_updown = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serPrice_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceType_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.serDuration_pick);
            this.panel1.Controls.Add(this.addserRec_btn);
            this.panel1.Controls.Add(this.serAvail_updown);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.serPrice_field);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.serviceType_field);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 218);
            this.panel1.TabIndex = 0;
            // 
            // serDuration_pick
            // 
            this.serDuration_pick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.serDuration_pick.Location = new System.Drawing.Point(120, 114);
            this.serDuration_pick.Name = "serDuration_pick";
            this.serDuration_pick.Size = new System.Drawing.Size(103, 20);
            this.serDuration_pick.TabIndex = 10;
            // 
            // addserRec_btn
            // 
            this.addserRec_btn.BackColor = System.Drawing.Color.Yellow;
            this.addserRec_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.addserRec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addserRec_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addserRec_btn.Location = new System.Drawing.Point(338, 175);
            this.addserRec_btn.Name = "addserRec_btn";
            this.addserRec_btn.Size = new System.Drawing.Size(123, 31);
            this.addserRec_btn.TabIndex = 9;
            this.addserRec_btn.Text = "Add";
            this.addserRec_btn.UseVisualStyleBackColor = false;
            this.addserRec_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // serAvail_updown
            // 
            this.serAvail_updown.Location = new System.Drawing.Point(119, 151);
            this.serAvail_updown.Name = "serAvail_updown";
            this.serAvail_updown.Size = new System.Drawing.Size(104, 20);
            this.serAvail_updown.TabIndex = 7;
            this.serAvail_updown.Text = "domainUpDown1";
            this.serAvail_updown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Availability:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service Duration:";
            // 
            // serPrice_field
            // 
            this.serPrice_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serPrice_field.Location = new System.Drawing.Point(101, 73);
            this.serPrice_field.Name = "serPrice_field";
            this.serPrice_field.Size = new System.Drawing.Size(122, 20);
            this.serPrice_field.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Price:";
            // 
            // serviceType_field
            // 
            this.serviceType_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceType_field.Location = new System.Drawing.Point(101, 31);
            this.serviceType_field.Name = "serviceType_field";
            this.serviceType_field.Size = new System.Drawing.Size(122, 20);
            this.serviceType_field.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Service";
            // 
            // AddServicesRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(498, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddServicesRec";
            this.Text = "AddServicesRec";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serPrice_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceType_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown serAvail_updown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addserRec_btn;
        private System.Windows.Forms.DateTimePicker serDuration_pick;
    }
}