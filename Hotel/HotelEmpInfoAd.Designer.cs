namespace Hotel
{
    partial class HotelEmpInfoAd
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.accAdd_btn = new System.Windows.Forms.Button();
            this.accEdit_btn = new System.Windows.Forms.Button();
            this.accDel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(195, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(249, 61);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 5;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // accAdd_btn
            // 
            this.accAdd_btn.BackgroundImage = global::Hotel.Properties.Resources.icons8_add_50__1_;
            this.accAdd_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accAdd_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.accAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accAdd_btn.Location = new System.Drawing.Point(525, 59);
            this.accAdd_btn.Name = "accAdd_btn";
            this.accAdd_btn.Size = new System.Drawing.Size(31, 29);
            this.accAdd_btn.TabIndex = 6;
            this.accAdd_btn.UseVisualStyleBackColor = true;
            // 
            // accEdit_btn
            // 
            this.accEdit_btn.BackgroundImage = global::Hotel.Properties.Resources._448689817_1025153312536246_3189161376674832175_n;
            this.accEdit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accEdit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.accEdit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accEdit_btn.Location = new System.Drawing.Point(562, 59);
            this.accEdit_btn.Name = "accEdit_btn";
            this.accEdit_btn.Size = new System.Drawing.Size(31, 29);
            this.accEdit_btn.TabIndex = 7;
            this.accEdit_btn.UseVisualStyleBackColor = true;
            // 
            // accDel_btn
            // 
            this.accDel_btn.BackgroundImage = global::Hotel.Properties.Resources.icons8_delete_30;
            this.accDel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.accDel_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.accDel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accDel_btn.Location = new System.Drawing.Point(599, 59);
            this.accDel_btn.Name = "accDel_btn";
            this.accDel_btn.Size = new System.Drawing.Size(31, 29);
            this.accDel_btn.TabIndex = 8;
            this.accDel_btn.UseVisualStyleBackColor = true;
            // 
            // HotelEmpInfoAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.accDel_btn);
            this.Controls.Add(this.accEdit_btn);
            this.Controls.Add(this.accAdd_btn);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "HotelEmpInfoAd";
            this.Size = new System.Drawing.Size(643, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button accAdd_btn;
        private System.Windows.Forms.Button accEdit_btn;
        private System.Windows.Forms.Button accDel_btn;
    }
}
