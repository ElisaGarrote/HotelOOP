namespace Hotel
{
    partial class HotelRoomAd
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.addRooms_btn = new System.Windows.Forms.Button();
            this.editRoom_btn = new System.Windows.Forms.Button();
            this.deleteRoom_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rooms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 286);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search:";
            // 
            // search_box
            // 
            this.search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_box.Location = new System.Drawing.Point(55, 63);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(129, 20);
            this.search_box.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(204, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown1.Location = new System.Drawing.Point(243, 63);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "domainUpDown1";
            this.domainUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // addRooms_btn
            // 
            this.addRooms_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRooms_btn.BackgroundImage = global::Hotel.Properties.Resources.icons8_add_50__1_;
            this.addRooms_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addRooms_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addRooms_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRooms_btn.Location = new System.Drawing.Point(541, 58);
            this.addRooms_btn.Name = "addRooms_btn";
            this.addRooms_btn.Size = new System.Drawing.Size(28, 25);
            this.addRooms_btn.TabIndex = 12;
            this.addRooms_btn.UseVisualStyleBackColor = true;
            this.addRooms_btn.Click += new System.EventHandler(this.addRooms_btn_Click);
            // 
            // editRoom_btn
            // 
            this.editRoom_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editRoom_btn.BackgroundImage = global::Hotel.Properties.Resources._448689817_1025153312536246_3189161376674832175_n;
            this.editRoom_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editRoom_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editRoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoom_btn.Location = new System.Drawing.Point(573, 58);
            this.editRoom_btn.Name = "editRoom_btn";
            this.editRoom_btn.Size = new System.Drawing.Size(31, 25);
            this.editRoom_btn.TabIndex = 13;
            this.editRoom_btn.UseVisualStyleBackColor = true;
            // 
            // deleteRoom_btn
            // 
            this.deleteRoom_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRoom_btn.BackgroundImage = global::Hotel.Properties.Resources.icons8_delete_30;
            this.deleteRoom_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteRoom_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteRoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoom_btn.Location = new System.Drawing.Point(607, 58);
            this.deleteRoom_btn.Name = "deleteRoom_btn";
            this.deleteRoom_btn.Size = new System.Drawing.Size(24, 27);
            this.deleteRoom_btn.TabIndex = 14;
            this.deleteRoom_btn.UseVisualStyleBackColor = true;
            // 
            // HotelRoomAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.deleteRoom_btn);
            this.Controls.Add(this.editRoom_btn);
            this.Controls.Add(this.addRooms_btn);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "HotelRoomAd";
            this.Size = new System.Drawing.Size(643, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button addRooms_btn;
        private System.Windows.Forms.Button editRoom_btn;
        private System.Windows.Forms.Button deleteRoom_btn;
    }
}
