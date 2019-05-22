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
using OnlineBookStore.Properties;
using System.IO;

namespace OnlineBookStore
{
    public partial class AdminBilgi : Form
    {
        public AdminBilgi()
        {
            InitializeComponent();
        }
        Customer cs = new Customer();

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public string dene;
        public string aorc;
        private void AdminBilgi_Load(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            label2.Text = dene;
           if(aorc == "false")
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_Customer where Username=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dene);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Txtid.Text = dr[0].ToString();
                    TxtName.Text = dr[1].ToString();
                    TxtAddress.Text = dr[2].ToString();
                    TxtEmail.Text = dr[3].ToString();
                    TxtUsername.Text = dr[4].ToString();
                    TxtPassword.Text = dr[5].ToString();
                }
                bgl.baglanti().Close();

                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Resources\ProfilePictures\admin.png");
                
            }
           if(aorc == "true")
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_AdminUser where Username=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dene);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TxtName.Text = dr[1].ToString();
                    TxtAddress.Text = dr[2].ToString();
                    TxtEmail.Text = dr[3].ToString();
                    TxtUsername.Text = dr[4].ToString();
                    TxtPassword.Text = dr[5].ToString();
                }
                bgl.baglanti().Close();
            }
            

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Customer set Name=@p1,Address=@p2,Email=@p3,Username=@p4,Password=@p5 where id=@p6 ", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtName.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtAddress.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtEmail.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtUsername.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtPassword.Text);
            komutguncelle.Parameters.AddWithValue("@p6", Txtid.Text);
            komutguncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Kişi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
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


                pictureBox1.Image = Image.FromFile(filepath);
                cs.Image = Image.FromFile(filepath);
            }
            catch
            {

            }
        }
    }
}
