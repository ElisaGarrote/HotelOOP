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
            this.SuspendLayout();
            // 
            // log_inbutton
            // 
            this.log_inbutton.Location = new System.Drawing.Point(292, 237);
            this.log_inbutton.Name = "log_inbutton";
            this.log_inbutton.Size = new System.Drawing.Size(216, 96);
            this.log_inbutton.TabIndex = 0;
            this.log_inbutton.Text = "button1";
            this.log_inbutton.UseVisualStyleBackColor = true;
            this.log_inbutton.Click += new System.EventHandler(this.log_inbutton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log_inbutton);
            this.Name = "Form1";
            this.ResumeLayout(false);

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
    }
}

