namespace Hotel
{
    partial class Form1
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
            this.log_inbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_field = new System.Windows.Forms.TextBox();
            this.pass_field = new System.Windows.Forms.TextBox();
            this.forgot_passbutton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // log_inbutton
            // 
            this.log_inbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_inbutton.BackColor = System.Drawing.Color.Yellow;
            this.log_inbutton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.log_inbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_inbutton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_inbutton.Location = new System.Drawing.Point(348, 310);
            this.log_inbutton.Name = "log_inbutton";
            this.log_inbutton.Size = new System.Drawing.Size(152, 34);
            this.log_inbutton.TabIndex = 0;
            this.log_inbutton.Text = "Log In";
            this.log_inbutton.UseVisualStyleBackColor = false;
            this.log_inbutton.Click += new System.EventHandler(this.log_inbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Hotel.Properties.Resources.logi1_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(298, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(263, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(267, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // username_field
            // 
            this.username_field.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_field.Location = new System.Drawing.Point(330, 224);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(187, 20);
            this.username_field.TabIndex = 4;
            // 
            // pass_field
            // 
            this.pass_field.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_field.Location = new System.Drawing.Point(331, 253);
            this.pass_field.Name = "pass_field";
            this.pass_field.Size = new System.Drawing.Size(186, 20);
            this.pass_field.TabIndex = 5;
            // 
            // forgot_passbutton
            // 
            this.forgot_passbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgot_passbutton.AutoSize = true;
            this.forgot_passbutton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_passbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forgot_passbutton.Location = new System.Drawing.Point(425, 281);
            this.forgot_passbutton.Name = "forgot_passbutton";
            this.forgot_passbutton.Size = new System.Drawing.Size(87, 13);
            this.forgot_passbutton.TabIndex = 6;
            this.forgot_passbutton.Text = "Forgot Password?";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgot_passbutton);
            this.Controls.Add(this.pass_field);
            this.Controls.Add(this.username_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.log_inbutton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reefs Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button log_in_button;
        private System.Windows.Forms.Button log_inbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_field;
        private System.Windows.Forms.TextBox pass_field;
        private System.Windows.Forms.Label forgot_passbutton;
    }
}

