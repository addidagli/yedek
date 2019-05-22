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
    public partial class AdminBilgiDuzenle : Form
    {

        public AdminBilgiDuzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        Customer cs = new Customer();
        private void AdminBilgiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet13.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter1.Fill(this.onlineBookStoreDBDataSet13.Tbl_Customer);
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet12.Tbl_MusicCD' table. You can move, or remove it, as needed.
            this.tbl_MusicCDTableAdapter1.Fill(this.onlineBookStoreDBDataSet12.Tbl_MusicCD);
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet11.Tbl_Magazine' table. You can move, or remove it, as needed.
            this.tbl_MagazineTableAdapter1.Fill(this.onlineBookStoreDBDataSet11.Tbl_Magazine);
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet10.Tbl_Book' table. You can move, or remove it, as needed.
            this.tbl_BookTableAdapter3.Fill(this.onlineBookStoreDBDataSet10.Tbl_Book);
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet91.Tbl_Book' table. You can move, or remove it, as needed.
            this.tbl_BookTableAdapter1.Fill(this.onlineBookStoreDBDataSet91.Tbl_Book);
            // TODO: This line of code loads data into the 'onlineBookStoreDBDataSet5.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.onlineBookStoreDBDataSet5.Tbl_Customer);
          
         


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id,Name,Address,Email,Username,Password From Tbl_Customer", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select id,isbnNumber,Author,Page,Publisher,BookName,Price From Tbl_Book", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select id,issue,Type,MagazineName,Price From Tbl_Magazine", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select id,singer,Type,MusicName,Price From Tbl_MusicCD", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //cs.saveCustomer();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Customer set Name=@p1,Address=@p2,Email=@p3,UserName=@p4,Password=@p5 where id=@p6", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txtName.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtAddress.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtEmail.Text);
            komutguncelle.Parameters.AddWithValue("@p4", txtUsername.Text);
            komutguncelle.Parameters.AddWithValue("@p5", txtPassword.Text);
            komutguncelle.Parameters.AddWithValue("@p6", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgliler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id,Name,Address,Email,Username,Password From Tbl_Customer", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Customer where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id,Name,Address,Email,Username,Password From Tbl_Customer", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_kaydetKitap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Book (isbnNumber,Author,Page,Publisher,BookName,Price) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtisbnNumber.Text);
            komut.Parameters.AddWithValue("@p2", TxtAuthor.Text);
            komut.Parameters.AddWithValue("@p3", TxtPage.Text);
            komut.Parameters.AddWithValue("@p4", TxtPublisher.Text);
            komut.Parameters.AddWithValue("@p5", TxtBookName.Text);
            komut.Parameters.AddWithValue("@p6", TxtBookPrice.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select id,isbnNumber,Author,Page,Publisher,BookName,Price From Tbl_Book", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }

        private void btn_ekleKitap_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Book set isbnNumber=@p1,Author=@p2,Page=@p3,Publisher=@p4,BookName=@p6,Price=@p7 where id=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtisbnNumber.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtAuthor.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtPage.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtPublisher.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtBookid.Text);
            komutguncelle.Parameters.AddWithValue("@p6", TxtBookName.Text);
            komutguncelle.Parameters.AddWithValue("@p7", TxtBookPrice.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select id,isbnNumber,Author,Page,Publisher,BookName,Price From Tbl_Book", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btn_SilKitap_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Book where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtBookid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select id,isbnNumber,Author,Page,Publisher,BookName,Price From Tbl_Book", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void btn_ekleMagazine_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Magazine (issue,type,MagazineName,Price) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMagazineIssue.Text);
            komut.Parameters.AddWithValue("@p2", TxtMagazineType.Text);
            komut.Parameters.AddWithValue("@p3", TxtMagazineName.Text);
            komut.Parameters.AddWithValue("@p4", TxtMagazinePrice.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Magazine Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select id,issue,Type,MagazineName,Price From Tbl_Magazine", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }

        private void BtnMagazineGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Magazine set issue=@p1,type=@p2,MagazineName=@p4,Price=@p5 where id=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtMagazineIssue.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtMagazineType.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtMagazineid.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtMagazineName.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtMagazinePrice.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Magazine Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select id,issue,Type,MagazineName,Price From Tbl_Magazine", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }

        private void BtnMagazineSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Magazine where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtMagazineid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Magazine Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select id,issue,Type,MagazineName,Price From Tbl_Magazine", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }

        private void BtnMusicEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_MusicCD (singer,type,MusicName,Price) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtSinger.Text);
            komut.Parameters.AddWithValue("@p2", TxtMusicType.Text);
            komut.Parameters.AddWithValue("@p3", TxtMusicName.Text);
            komut.Parameters.AddWithValue("@p4", TxtMusicPrice.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müzik Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select id,singer,Type,MusicName,Price From Tbl_MusicCD", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }

        private void BtnMusicGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_MusicCD set singer=@p1,type=@p2,MusicName=@p4,Price=@p5 where id=@p3", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtSinger.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtMusicType.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtMusicID.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtMusicName.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtMusicPrice.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müzik Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select id,singer,Type,MusicName,Price From Tbl_MusicCD", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }

        private void BtnMusicSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_MusicCD where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtMusicID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müzik Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select id,singer,Type,MusicName,Price From Tbl_MusicCD", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                openFileDialog1.Title = "Dosya seçiniz.";
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                string destPath = Application.StartupPath + @"\Resources\book\" + book.Name + ".png";

                Directory.CreateDirectory(Application.StartupPath + @"\Resources\book\");
                File.Copy(filepath, destPath, true);

                txt_imageName.Text = openFileDialog1.FileName.ToString();

                pictureBox1.Image = Image.FromFile(filepath);
                cs.Image = Image.FromFile(filepath);
            }
            catch { }
        }

        private void btn_chosePicture_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Magazine magazine = new Magazine();
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                openFileDialog1.Title = "Dosya seçiniz.";
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                string destPath = Application.StartupPath + @"\Resources\magazine\" + magazine.Name + ".png";

                Directory.CreateDirectory(Application.StartupPath + @"\Resources\magazine\");
                File.Copy(filepath, destPath, true);

                txt_imageName.Text = openFileDialog1.FileName.ToString();

                pictureBox1.Image = Image.FromFile(filepath);
                cs.Image = Image.FromFile(filepath);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MusicCD musicCD = new MusicCD();
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                openFileDialog1.Title = "Dosya seçiniz.";
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                string destPath = Application.StartupPath + @"\Resources\müzik\" + musicCD.Name + ".png";

                Directory.CreateDirectory(Application.StartupPath + @"\Resources\müzik\");
                File.Copy(filepath, destPath, true);

                txt_imageName.Text = openFileDialog1.FileName.ToString();

                pictureBox1.Image = Image.FromFile(filepath);
                cs.Image = Image.FromFile(filepath);
            }
            catch { }
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtBookid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtisbnNumber.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            TxtAuthor.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            TxtPage.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            TxtPublisher.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            TxtBookName.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            TxtBookPrice.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            TxtMagazineid.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();
            TxtMagazineIssue.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            TxtMagazineType.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
            TxtMagazineName.Text = dataGridView3.Rows[secilen].Cells[3].Value.ToString();
            TxtMagazinePrice.Text = dataGridView3.Rows[secilen].Cells[4].Value.ToString();


        }

        private void dataGridView4_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView4.SelectedCells[0].RowIndex;
            TxtMusicID.Text = dataGridView4.Rows[secilen].Cells[0].Value.ToString();
            TxtSinger.Text = dataGridView4.Rows[secilen].Cells[1].Value.ToString();
            TxtMusicType.Text = dataGridView4.Rows[secilen].Cells[2].Value.ToString();
            TxtMusicName.Text = dataGridView4.Rows[secilen].Cells[3].Value.ToString();
            TxtMusicPrice.Text = dataGridView4.Rows[secilen].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
