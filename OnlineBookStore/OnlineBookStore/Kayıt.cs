using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OnlineBookStore
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        Customer cs = new Customer();

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text == "" || TxtUserName.Text == "" || TxtPassword.Text == "" || TxtAddress.Text == "" || TxtEmail.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TxtPassword.Text == TxtPasswordAgain.Text)
                    {

                        SqlCommand komut = new SqlCommand("insert into Tbl_Customer (Name,Username,Password,Address,Email) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", TxtName.Text);
                        komut.Parameters.AddWithValue("@p2", TxtUserName.Text);
                        komut.Parameters.AddWithValue("@p3", TxtPassword.Text);
                        komut.Parameters.AddWithValue("@p4", TxtAddress.Text);
                        komut.Parameters.AddWithValue("@p5", TxtEmail.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Kaydınız Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Üye kaydı yapılamadı. Girilen şifreler uyuşmuyor.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı daha önceden alınmıştır.");
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if(TxtEmail.Text == "something@gmail.com")
            {
                TxtEmail.Text = "";

                TxtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {

            if (TxtEmail.Text == "")
            {
                TxtEmail.Text = "something@gmail.com";

                TxtEmail.ForeColor = Color.Silver;
            }
        }

        private void BtnFotoSec_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                openFileDialog1.Title = "Dosya seçiniz.";
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                string destPath = Application.StartupPath + @"\Resources\ProfilePictures\" + cs.Username + ".png";

                Directory.CreateDirectory(Application.StartupPath + @"\Resources\ProfilePictures\");
                File.Copy(filepath, destPath, true);

                txt_imageName.Text = openFileDialog1.FileName.ToString();

                pictureBox1.Image = Image.FromFile(filepath);
                cs.Image = Image.FromFile(filepath);
            }
            catch { }
        }
    }
}
