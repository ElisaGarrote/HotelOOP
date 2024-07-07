namespace Hotel
{
    partial class AdminMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_promobut = new System.Windows.Forms.Button();
            this.add_employeebut = new System.Windows.Forms.Button();
            this.add_servicesbut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emp_namelabel = new System.Windows.Forms.Label();
            this.adminMain_btn = new System.Windows.Forms.Button();
            this.adminReports_btn = new System.Windows.Forms.Button();
            this.hotelRoomAd1 = new Hotel.HotelRoomAd();
            this.userControl11 = new Hotel.HotelRoomAd();
            this.adminLogout_btn = new System.Windows.Forms.Button();
            this.adminProfile_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.add_promobut);
            this.panel1.Controls.Add(this.add_employeebut);
            this.panel1.Controls.Add(this.add_servicesbut);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 380);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "8:58:40 ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "July 4, 2024";
            // 
            // add_promobut
            // 
            this.add_promobut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_promobut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_promobut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_promobut.Location = new System.Drawing.Point(3, 171);
            this.add_promobut.Name = "add_promobut";
            this.add_promobut.Size = new System.Drawing.Size(149, 49);
            this.add_promobut.TabIndex = 7;
            this.add_promobut.Text = "Promotions";
            this.add_promobut.UseVisualStyleBackColor = true;
            this.add_promobut.Click += new System.EventHandler(this.add_promobut_Click);
            // 
            // add_employeebut
            // 
            this.add_employeebut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_employeebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_employeebut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_employeebut.Location = new System.Drawing.Point(3, 116);
            this.add_employeebut.Name = "add_employeebut";
            this.add_employeebut.Size = new System.Drawing.Size(149, 49);
            this.add_employeebut.TabIndex = 7;
            this.add_employeebut.Text = "Hotel Employees";
            this.add_employeebut.UseVisualStyleBackColor = true;
            // 
            // add_servicesbut
            // 
            this.add_servicesbut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_servicesbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_servicesbut.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_servicesbut.Location = new System.Drawing.Point(3, 61);
            this.add_servicesbut.Name = "add_servicesbut";
            this.add_servicesbut.Size = new System.Drawing.Size(149, 49);
            this.add_servicesbut.TabIndex = 7;
            this.add_servicesbut.Text = "Hotel Services";
            this.add_servicesbut.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hotel Rooms";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // emp_namelabel
            // 
            this.emp_namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_namelabel.AutoSize = true;
            this.emp_namelabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_namelabel.Location = new System.Drawing.Point(624, 22);
            this.emp_namelabel.Name = "emp_namelabel";
            this.emp_namelabel.Size = new System.Drawing.Size(89, 14);
            this.emp_namelabel.TabIndex = 4;
            this.emp_namelabel.Text = "Employee Name";
            this.emp_namelabel.Click += new System.EventHandler(this.emp_namelabel_Click);
            // 
            // adminMain_btn
            // 
            this.adminMain_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminMain_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminMain_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMain_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMain_btn.Location = new System.Drawing.Point(504, 18);
            this.adminMain_btn.Name = "adminMain_btn";
            this.adminMain_btn.Size = new System.Drawing.Size(49, 23);
            this.adminMain_btn.TabIndex = 11;
            this.adminMain_btn.Text = "Main";
            this.adminMain_btn.UseVisualStyleBackColor = true;
            // 
            // adminReports_btn
            // 
            this.adminReports_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminReports_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminReports_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminReports_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminReports_btn.Location = new System.Drawing.Point(555, 18);
            this.adminReports_btn.Name = "adminReports_btn";
            this.adminReports_btn.Size = new System.Drawing.Size(63, 23);
            this.adminReports_btn.TabIndex = 12;
            this.adminReports_btn.Text = "Reports";
            this.adminReports_btn.UseVisualStyleBackColor = true;
            // 
            // hotelRoomAd1
            // 
            this.hotelRoomAd1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelRoomAd1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotelRoomAd1.Location = new System.Drawing.Point(157, 69);
            this.hotelRoomAd1.Name = "hotelRoomAd1";
            this.hotelRoomAd1.Size = new System.Drawing.Size(643, 380);
            this.hotelRoomAd1.TabIndex = 8;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.userControl11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl11.Location = new System.Drawing.Point(161, 71);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(632, 377);
            this.userControl11.TabIndex = 2;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // adminLogout_btn
            // 
            this.adminLogout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminLogout_btn.BackgroundImage = global::Hotel.Properties.Resources.logout_button;
            this.adminLogout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminLogout_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminLogout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogout_btn.Location = new System.Drawing.Point(754, 8);
            this.adminLogout_btn.Name = "adminLogout_btn";
            this.adminLogout_btn.Size = new System.Drawing.Size(34, 29);
            this.adminLogout_btn.TabIndex = 10;
            this.adminLogout_btn.UseVisualStyleBackColor = true;
            // 
            // adminProfile_btn
            // 
            this.adminProfile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminProfile_btn.BackgroundImage = global::Hotel.Properties.Resources.profile_logo;
            this.adminProfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminProfile_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminProfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProfile_btn.Location = new System.Drawing.Point(716, 6);
            this.adminProfile_btn.Name = "adminProfile_btn";
            this.adminProfile_btn.Size = new System.Drawing.Size(37, 31);
            this.adminProfile_btn.TabIndex = 9;
            this.adminProfile_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.RoyalReefMainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminReports_btn);
            this.Controls.Add(this.adminMain_btn);
            this.Controls.Add(this.adminLogout_btn);
            this.Controls.Add(this.adminProfile_btn);
            this.Controls.Add(this.hotelRoomAd1);
            this.Controls.Add(this.emp_namelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Reefs Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private HotelRoomAd userControl11;
        private System.Windows.Forms.Label emp_namelabel;
        private System.Windows.Forms.Button add_servicesbut;
        private System.Windows.Forms.Button add_employeebut;
        private System.Windows.Forms.Button add_promobut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HotelRoomAd hotelRoomAd1;
        private System.Windows.Forms.Button adminProfile_btn;
        private System.Windows.Forms.Button adminLogout_btn;
        private System.Windows.Forms.Button adminMain_btn;
        private System.Windows.Forms.Button adminReports_btn;
    }
}