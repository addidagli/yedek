namespace OnlineBookStore
{
    partial class Anasayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picShoppingCart = new System.Windows.Forms.PictureBox();
            this.AdminSettings = new System.Windows.Forms.PictureBox();
            this.pictureMyProfile = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtAra);
            this.groupBox1.Controls.Add(this.CmbUrun);
            this.groupBox1.Location = new System.Drawing.Point(133, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1083, 51);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // BtnAra
            // 
            this.BtnAra.BackgroundImage = global::OnlineBookStore.Properties.Resources._698627_icon_111_search_512;
            this.BtnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAra.Location = new System.Drawing.Point(829, 11);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(37, 35);
            this.BtnAra.TabIndex = 29;
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün";
            // 
            // TxtAra
            // 
            this.TxtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAra.ForeColor = System.Drawing.Color.Silver;
            this.TxtAra.Location = new System.Drawing.Point(254, 12);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(569, 34);
            this.TxtAra.TabIndex = 28;
            this.TxtAra.Text = "Search Something...";
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            this.TxtAra.Enter += new System.EventHandler(this.TxtAra_Enter);
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Items.AddRange(new object[] {
            "All",
            "Book",
            "Magazine",
            "Music CD"});
            this.CmbUrun.Location = new System.Drawing.Point(84, 20);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(121, 24);
            this.CmbUrun.TabIndex = 0;
            this.CmbUrun.Text = "All";
            this.CmbUrun.SelectedIndexChanged += new System.EventHandler(this.CmbUrun_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(133, 145);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1083, 501);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1030, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // picShoppingCart
            // 
            this.picShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShoppingCart.Image = global::OnlineBookStore.Properties.Resources.indir;
            this.picShoppingCart.Location = new System.Drawing.Point(12, 268);
            this.picShoppingCart.Name = "picShoppingCart";
            this.picShoppingCart.Size = new System.Drawing.Size(116, 108);
            this.picShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShoppingCart.TabIndex = 25;
            this.picShoppingCart.TabStop = false;
            this.picShoppingCart.Click += new System.EventHandler(this.picShoppingCart_Click);
            // 
            // AdminSettings
            // 
            this.AdminSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminSettings.Image = global::OnlineBookStore.Properties.Resources.admin_setting_4_5599341;
            this.AdminSettings.Location = new System.Drawing.Point(22, 400);
            this.AdminSettings.Name = "AdminSettings";
            this.AdminSettings.Size = new System.Drawing.Size(95, 97);
            this.AdminSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminSettings.TabIndex = 24;
            this.AdminSettings.TabStop = false;
            this.AdminSettings.Click += new System.EventHandler(this.AdminSettings_Click);
            // 
            // pictureMyProfile
            // 
            this.pictureMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMyProfile.Image = global::OnlineBookStore.Properties.Resources.myprofile;
            this.pictureMyProfile.Location = new System.Drawing.Point(12, 135);
            this.pictureMyProfile.Name = "pictureMyProfile";
            this.pictureMyProfile.Size = new System.Drawing.Size(116, 108);
            this.pictureMyProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMyProfile.TabIndex = 22;
            this.pictureMyProfile.TabStop = false;
            this.pictureMyProfile.Click += new System.EventHandler(this.pictureMyProfile_Click);
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::OnlineBookStore.Properties.Resources.black_power_button_icon_8;
            this.picExit.Location = new System.Drawing.Point(22, 528);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(95, 97);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 23;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 85);
            this.panel1.TabIndex = 31;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picShoppingCart);
            this.Controls.Add(this.AdminSettings);
            this.Controls.Add(this.pictureMyProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Anasayfa";
            this.Text = "AdminAnasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMyProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picShoppingCart;
        private System.Windows.Forms.PictureBox AdminSettings;
        private System.Windows.Forms.PictureBox pictureMyProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}