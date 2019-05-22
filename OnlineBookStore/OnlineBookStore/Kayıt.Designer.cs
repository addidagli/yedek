namespace OnlineBookStore
{
    partial class Kayıt
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
            this.BtnKayıtOl = new System.Windows.Forms.Button();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPasswordAgain = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.BtnFotoSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_imageName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKayıtOl
            // 
            this.BtnKayıtOl.BackColor = System.Drawing.Color.Silver;
            this.BtnKayıtOl.Location = new System.Drawing.Point(264, 617);
            this.BtnKayıtOl.Name = "BtnKayıtOl";
            this.BtnKayıtOl.Size = new System.Drawing.Size(166, 51);
            this.BtnKayıtOl.TabIndex = 23;
            this.BtnKayıtOl.Text = "Sign up";
            this.BtnKayıtOl.UseVisualStyleBackColor = false;
            this.BtnKayıtOl.Click += new System.EventHandler(this.BtnKayıtOl_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(236, 313);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(281, 34);
            this.TxtUserName.TabIndex = 16;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(236, 271);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(281, 34);
            this.TxtName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Again Password:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.ForeColor = System.Drawing.Color.Silver;
            this.TxtEmail.Location = new System.Drawing.Point(236, 435);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(281, 34);
            this.TxtEmail.TabIndex = 29;
            this.TxtEmail.Text = "something@gmail.com";
            this.TxtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtPasswordAgain
            // 
            this.TxtPasswordAgain.Location = new System.Drawing.Point(236, 395);
            this.TxtPasswordAgain.Name = "TxtPasswordAgain";
            this.TxtPasswordAgain.Size = new System.Drawing.Size(281, 34);
            this.TxtPasswordAgain.TabIndex = 30;
            this.TxtPasswordAgain.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(236, 353);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(281, 34);
            this.TxtPassword.TabIndex = 31;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(236, 475);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(281, 105);
            this.TxtAddress.TabIndex = 32;
            this.TxtAddress.UseSystemPasswordChar = true;
            // 
            // BtnFotoSec
            // 
            this.BtnFotoSec.BackColor = System.Drawing.Color.Silver;
            this.BtnFotoSec.Location = new System.Drawing.Point(462, 210);
            this.BtnFotoSec.Name = "BtnFotoSec";
            this.BtnFotoSec.Size = new System.Drawing.Size(55, 34);
            this.BtnFotoSec.TabIndex = 34;
            this.BtnFotoSec.Text = "...";
            this.BtnFotoSec.UseVisualStyleBackColor = false;
            this.BtnFotoSec.Click += new System.EventHandler(this.BtnFotoSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(264, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_imageName
            // 
            this.txt_imageName.Location = new System.Drawing.Point(264, 210);
            this.txt_imageName.Name = "txt_imageName";
            this.txt_imageName.Size = new System.Drawing.Size(179, 34);
            this.txt_imageName.TabIndex = 35;
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(575, 754);
            this.Controls.Add(this.txt_imageName);
            this.Controls.Add(this.BtnFotoSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtPasswordAgain);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnKayıtOl);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kayıt";
            this.Text = "Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayıtOl;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPasswordAgain;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFotoSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_imageName;
    }
}