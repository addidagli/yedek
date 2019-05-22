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

namespace OnlineBookStore
{
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            InitializeComponent();
        }
        Customer cs = new Customer();
        int i = 0;


        Sqlbaglantisi bgl = new Sqlbaglantisi();

        List<Book> bookList = new List<Book>();
        List<Magazine> magazinelist = new List<Magazine>();
        List<MusicCD> musicCDlist = new List<MusicCD>();
        List<Book> BookSearch = new List<Book>();
        List<Magazine> MagazineSearch = new List<Magazine>();
        List<MusicCD> MusicSearch = new List<MusicCD>();
       
        public string control;
        public string user;
        public double bookmiktar;
        public double magazinemiktar;
        public double musicmiktar;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            label1.Text = control;
            label4.Text = user;
            
            if (label1.Text == "false")
            {
                AdminSettings.Visible = false;
            }
            if (label1.Text == "true")
            {
                AdminSettings.Visible = true;
            }
            getBook();
            getComboBook(bookList);
            getMagazine();
            getComboMagazine(magazinelist);
            getMusicCD();
            getComboMusicCD(musicCDlist);




        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMyProfile_Click(object sender, EventArgs e)
        {
            AdminBilgi frm = new AdminBilgi();
            frm.dene = label4.Text;
            frm.aorc = label1.Text;
            frm.Show();
        }

        private void AdminSettings_Click(object sender, EventArgs e)
        {
            AdminBilgiDuzenle frm = new AdminBilgiDuzenle();
            frm.Show();
            this.Hide();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SearchBook();

        }

        private void CmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panel temizlemek için
            flowLayoutPanel1.Controls.Clear();
          
        
        

            if (CmbUrun.SelectedItem.ToString() == "Book")
            {
                flowLayoutPanel1.Controls.Clear();
                getComboBook(bookList);
            }
            if (CmbUrun.SelectedItem.ToString() == "Magazine")
            {
                flowLayoutPanel1.Controls.Clear();
                getComboMagazine(magazinelist);
            }
            if (CmbUrun.SelectedItem.ToString() == "Music CD")
            {
                flowLayoutPanel1.Controls.Clear();
                getComboMusicCD(musicCDlist);
            }
            if (CmbUrun.SelectedItem.ToString() == "All")
            {
                flowLayoutPanel1.Controls.Clear();
                getComboBook(bookList);
                getComboMagazine(magazinelist);
                getComboMusicCD(musicCDlist);
            }
        }

        void getBook()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Book", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Book book = new Book();
                book.ID = Convert.ToUInt16(dr[0]);
                book.ISBN_Number = dr[1].ToString();
                book.Author = dr[2].ToString();
                book.Page = Convert.ToInt16(dr[3]);
                book.Publisher = dr[4].ToString();
                book.Name = dr[6].ToString();
                book.Price = Convert.ToDouble(dr[7]);



                try
                {
                    book.Image = Image.FromFile(Application.StartupPath + @"\Resources\book\" + book.Name + ".png");
                }
                catch
                {
                    book.Image = Resources.notfound;
                }
                bookList.Add(book);
            }
            bgl.baglanti().Close();
        }
        void getComboBook(List<Book> al)
        {
            for (int j = 0; j < al.Count; j++)
            {
                Panel Pnl = new Panel();
                Pnl.BackColor = Color.White;
                Pnl.BorderStyle = BorderStyle.FixedSingle;
                Pnl.Name = "Pnl" + i.ToString();
                Size sz = new Size(263, 214);
                Pnl.Size = sz;
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Label lbl4 = new Label();
                Label lbl5 = new Label();
                Label lbl6 = new Label();
                

                lbl1.Name = "lbl1_" + i.ToString();
                lbl2.Name = "lbl2_" + i.ToString();
                lbl3.Name = "lbl3_" + i.ToString();
                lbl4.Name = "lbl4_" + i.ToString();
                lbl5.Name = "lbl5_" + i.ToString();
                lbl6.Name = "lbl6_" + i.ToString();
                


                lbl1.Text = al[j].Name;
                lbl2.Text = al[j].ISBN_Number;
                lbl3.Text = al[j].Author.ToString();
                lbl4.Text = "Page :" + al[j].Page.ToString();
                lbl5.Text = al[j].Publisher;
                lbl6.Text = "Price: " + al[j].Price.ToString();
                bookmiktar = al[j].Price;



                Point position = new Point(135, 22);
                lbl1.Location = position;
                Point position2 = new Point(135, 43);
                lbl2.Location = position2;
                Point position3 = new Point(135, 64);
                lbl3.Location = position3;
                Point position4 = new Point(135, 85);
                lbl4.Location = position4;
                Point position5 = new Point(135, 106);
                lbl5.Location = position5;
                Point position6 = new Point(135, 148);
                lbl6.Location = position6;


                PictureBox pcbox = new PictureBox();
                pcbox.Name = "pcbox";
                Point position9 = new Point(2, 22);
                pcbox.Location = position9;
                Size sizePic = new Size(115, 154);
                pcbox.Size = sizePic;
                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbox.Image = al[j].Image;



                Button btn = new Button();
                Point positionBtn = new Point(192, 183);
                btn.Location = positionBtn;
                Size sizeBtn = new Size(58, 23);
                btn.Size = sizeBtn;
                btn.Name = "btn" + i.ToString();
                btn.Text = "Add";
                Book book = new Book();
                book.ID = al[j].ID;

                ComboBox cmbox = new ComboBox();
                Point locationCmbox = new Point(143, 183);
                cmbox.Location = locationCmbox;
                Size sizeCmbox = new Size(44, 23);
                cmbox.Size = sizeCmbox;

                for (int k = 1; k < 10; k++)
                {
                    cmbox.Items.Add(k);
                }
                cmbox.SelectedIndex = 0;

                SqlCommand komut1 = new SqlCommand("select id from Tbl_Customer where username=@p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", label4.Text);
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    cs.CustomerID = Convert.ToInt16(dr1[0]);
                }

                    btn.Click += delegate
                {
                    for (int l = 0; l < Convert.ToInt16(cmbox.Text); l++)
                    {

                        SqlCommand komut = new SqlCommand("insert into Tbl_ShoppingCard (Customerid,ItemtoPurchase,PaymentAmount,PaymentType) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p2", "Book");
                        komut.Parameters.AddWithValue("@p3", bookmiktar);
                        komut.Parameters.AddWithValue("@p1", cs.CustomerID);
                        komut.Parameters.AddWithValue("@p4", 1);

                        komut.ExecuteNonQuery();
                    }
                    bgl.baglanti().Close();
                    MessageBox.Show("Sepete eklendi.");
                };

                Pnl.Controls.Add(lbl1);
                Pnl.Controls.Add(lbl2);
                Pnl.Controls.Add(lbl3);
                Pnl.Controls.Add(lbl4);
                Pnl.Controls.Add(lbl5);
                Pnl.Controls.Add(lbl6);
                Pnl.Controls.Add(pcbox);
                Pnl.Controls.Add(btn);
                Pnl.Controls.Add(cmbox);

                flowLayoutPanel1.Controls.Add(Pnl);
                i++;
            }
        }
        void getMagazine()
        {

            SqlCommand komut = new SqlCommand("Select * From Tbl_Magazine", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Magazine magazine = new Magazine();
                magazine.ID = Convert.ToUInt16(dr[0]);
                magazine.Issue = dr[1].ToString();
                magazine.Type = dr[2].ToString();
                magazine.Name = dr[3].ToString();
                magazine.Price = Convert.ToDouble(dr[4]);

                try
                {
                    magazine.Image = Image.FromFile(Application.StartupPath + @"\Resources\magazine\" + magazine.Name + ".png");
                }
                catch
                {
                    magazine.Image = Resources.notfound;
                }
                magazinelist.Add(magazine);
            }
            
            bgl.baglanti().Close();

            
        }
       
        void getComboMagazine(List<Magazine> al)
        {
            for (int j = 0; j < al.Count; j++)
            {
                Panel Pnl = new Panel();
                Pnl.BackColor = Color.White;
                Pnl.BorderStyle = BorderStyle.FixedSingle;
                Pnl.Name = "Pnl" + i.ToString();
                Size sz = new Size(263, 214);
                Pnl.Size = sz;
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Label lbl4 = new Label();
                Label lbl5 = new Label();
                Label lbl6 = new Label();

                lbl1.Name = "lbl1_" + i.ToString();
                lbl2.Name = "lbl2_" + i.ToString();
                lbl3.Name = "lbl3_" + i.ToString();
                lbl4.Name = "lbl4_" + i.ToString();
                lbl5.Name = "lbl5_" + i.ToString();
                lbl6.Name = "lbl6_" + i.ToString();

                lbl1.Text = al[j].Name.ToString();
                lbl2.Text = al[j].Issue.ToString();
                lbl3.Text = al[j].Type.ToString();
                lbl4.Text = "Price: " + al[j].Price.ToString();
                magazinemiktar = al[j].Price;

                Point position = new Point(136, 33);
                lbl1.Location = position;
                Point position2 = new Point(136, 62);
                lbl2.Location = position2;
                Point position3 = new Point(136, 92);
                lbl3.Location = position3;
                Point position4 = new Point(136, 150);
                lbl4.Location = position4;
              
                PictureBox pcbox = new PictureBox();
                pcbox.Name = "pcbox" + i.ToString();

                Size sizePic = new Size(115, 154);
                pcbox.Size = sizePic;
                Point position6 = new Point(2, 22);
                pcbox.Location = position6;

                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbox.Image = al[j].Image;


                Button btn = new Button();
                Point positionBtn = new Point(192, 183);
                btn.Location = positionBtn;
                Size sizeBtn = new Size(58, 23);
                btn.Size = sizeBtn;
                btn.Name = "btn" + i.ToString();
                btn.Text = "Add";

                Magazine magazine = new Magazine();
                magazine.ID = al[j].ID;

                ComboBox cmbox = new ComboBox();
                Point locationCmbox = new Point(143, 183);
                cmbox.Location = locationCmbox;
                Size sizeCmbox = new Size(44, 23);
                cmbox.Size = sizeCmbox;

                for (int k = 1; k < 10; k++)
                {
                    cmbox.Items.Add(k);
                }
                cmbox.SelectedIndex = 0;

                btn.Click += delegate
                {
                    for (int l = 0; l < Convert.ToInt16(cmbox.Text); l++)
                    {
                        SqlCommand komut = new SqlCommand("insert into Tbl_ShoppingCard (Customerid,ItemtoPurchase,PaymentAmount,PaymentType) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p2", "Magazine");
                        komut.Parameters.AddWithValue("@p3", magazinemiktar);
                        komut.Parameters.AddWithValue("@p1", cs.CustomerID);
                        komut.Parameters.AddWithValue("@p4", 1);

                        komut.ExecuteNonQuery();
                    }
                    bgl.baglanti().Close();
                    MessageBox.Show("Sepete eklendi.");
                };

                Pnl.Controls.Add(lbl1);
                Pnl.Controls.Add(lbl2);
                Pnl.Controls.Add(lbl3);
                Pnl.Controls.Add(lbl4);
                //Pnl.Controls.Add(lbl5);
                Pnl.Controls.Add(pcbox);
                Pnl.Controls.Add(btn);
                Pnl.Controls.Add(cmbox);
                flowLayoutPanel1.Controls.Add(Pnl);
                i++;
            }
        }
        void getMusicCD()
        {

            SqlCommand komut = new SqlCommand("Select * From Tbl_MusicCD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                MusicCD musicCD = new MusicCD();
                musicCD.ID = Convert.ToUInt16(dr[0]);
                musicCD.Singer = dr[1].ToString();
                musicCD.Type = dr[2].ToString();
                musicCD.Name = dr[3].ToString();
                musicCD.Price = Convert.ToDouble(dr[4]);
               
                try
                {
                    musicCD.Image = Image.FromFile(Application.StartupPath + @"\Resources\müzik\" + musicCD.Name+ ".png");
                }
                catch
                {
                    musicCD.Image = Resources.notfound;
                }
                musicCDlist.Add(musicCD);
            }
            bgl.baglanti().Close();

            
        }
        void getComboMusicCD(List<MusicCD> bul)
        {
            for (int j = 0; j < bul.Count; j++)
            {
                Panel Pnl = new Panel();
                Pnl.BackColor = Color.White;
                Pnl.BorderStyle = BorderStyle.FixedSingle;
                Pnl.Name = "Pnl" + i.ToString();
                Size sz = new Size(263, 214);
                Pnl.Size = sz;
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Label lbl4 = new Label();
                Label lbl5 = new Label();
                lbl1.Name = "lbl1_" + i.ToString();
                lbl2.Name = "lbl2_" + i.ToString();
                lbl3.Name = "lbl3_" + i.ToString();
                lbl4.Name = "lbl4_" + i.ToString();
                lbl5.Name = "lbl5_" + i.ToString();

                lbl1.Text = bul[j].Name;
                lbl2.Text = bul[j].Singer.ToString();
                lbl3.Text = bul[j].Type;
                lbl4.Text = "Price: " + bul[j].Price.ToString();
                musicmiktar = bul[j].Price;

                Point position = new Point(135, 33);
                lbl1.Location = position;
                Point position2 = new Point(135, 62);
                lbl2.Location = position2;
                Point position3 = new Point(135, 92);
                lbl3.Location = position3;
                Point position4 = new Point(135, 150);
                lbl4.Location = position4;
                
                PictureBox pcbox = new PictureBox();
                pcbox.Name = "pcbox" + i.ToString();

                Size sizePic = new Size(115, 154);
                pcbox.Size = sizePic;
                Point position6 = new Point(2, 22);
                pcbox.Location = position6;

                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbox.Image = bul[j].Image;


                Button btn = new Button();
                Point positionBtn = new Point(192, 183);
                btn.Location = positionBtn;
                Size sizeBtn = new Size(58, 23);
                btn.Size = sizeBtn;
                btn.Name = "btn" + i.ToString();
                btn.Text = "Add";

                MusicCD musicCD = new MusicCD();
                musicCD.ID = bul[j].ID;

                ComboBox cmbox = new ComboBox();
                Point locationCmbox = new Point(143, 183);
                cmbox.Location = locationCmbox;
                Size sizeCmbox = new Size(44, 23);
                cmbox.Size = sizeCmbox;

                for (int k = 1; k < 10; k++)
                {
                    cmbox.Items.Add(k);
                }
                cmbox.SelectedIndex = 0;

                btn.Click += delegate
                {
                    for (int l = 0; l < Convert.ToInt16(cmbox.Text); l++)
                    {
                        SqlCommand komut = new SqlCommand("insert into Tbl_ShoppingCard (Customerid,ItemtoPurchase,PaymentAmount,PaymentType) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p2", "MusicCD");
                        komut.Parameters.AddWithValue("@p3", musicmiktar);
                        komut.Parameters.AddWithValue("@p1", cs.CustomerID);
                        komut.Parameters.AddWithValue("@p4", 1);

                        komut.ExecuteNonQuery();
                    }
                    bgl.baglanti().Close();
                    MessageBox.Show("Sepete eklendi.");
                };

                Pnl.Controls.Add(lbl1);
                Pnl.Controls.Add(lbl2);
                Pnl.Controls.Add(lbl3);
                Pnl.Controls.Add(lbl4);
                Pnl.Controls.Add(lbl5);
                Pnl.Controls.Add(pcbox);
                Pnl.Controls.Add(btn);
                Pnl.Controls.Add(cmbox);
                flowLayoutPanel1.Controls.Add(Pnl);
                i++;
            }
        }
        void SearchBook()
        {
            BookSearch.Clear();
            flowLayoutPanel1.Controls.Clear();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Book where author like '%" + TxtAra.Text + "%' or  publisher like  '%" + TxtAra.Text + "%' or isbnNumber like '%" + TxtAra.Text + "%' or BookName like '%" + TxtAra.Text + "%'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Book book = new Book();
                book.ID = Convert.ToUInt16(dr[0]);
                book.ISBN_Number = dr[1].ToString();
                book.Author = dr[2].ToString();
                book.Page = Convert.ToInt16(dr[3]);
                book.Publisher = dr[4].ToString();
                book.Name = dr[6].ToString();
                book.Price = Convert.ToDouble(dr[7]);
                try
                {
                    book.Image = Image.FromFile(Application.StartupPath + @"\Resources\book\" + book.Name + ".png");
                }
                catch
                {
                    book.Image = Resources.notfound;
                }

                BookSearch.Add(book);
                
            }
            bgl.baglanti().Close();
            getComboBook(BookSearch);


            MagazineSearch.Clear();
            SqlCommand komut3 = new SqlCommand("Select * From Tbl_Magazine where issue like '%" + TxtAra.Text + "%'  or type like '%" + TxtAra.Text + "%' or MagazineName like '%" + TxtAra.Text + "%'", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                Magazine magazine = new Magazine();
                magazine.ID = Convert.ToUInt16(dr3[0]);
                magazine.Issue = dr3[1].ToString();
                magazine.Type = dr3[2].ToString();
                magazine.Name = dr3[3].ToString();
                magazine.Price = Convert.ToDouble(dr3[4]);

                try
                {
                    magazine.Image = Image.FromFile(Application.StartupPath + @"\Resources\magazine\" + magazine.Name + ".png");
                }
                catch
                {
                    magazine.Image = Resources.notfound;
                }

                MagazineSearch.Add(magazine);

            }
            bgl.baglanti().Close();
            getComboMagazine(MagazineSearch);

            MusicSearch.Clear(); 
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_MusicCD where singer like '%" + TxtAra.Text + "%'  or type like '%" + TxtAra.Text + "%' or MusicName like '%" + TxtAra.Text + "%'", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

                MusicCD musicCD = new MusicCD();
                musicCD.ID = Convert.ToUInt16(dr2[0]);
                musicCD.Singer = dr2[1].ToString();
                musicCD.Type = dr2[2].ToString();
                musicCD.Name = dr2[3].ToString();
                musicCD.Price = Convert.ToDouble(dr2[4]);

                try
                {
                    musicCD.Image = Image.FromFile(Application.StartupPath + @"\Resources\müzik\" + musicCD.Name + ".png");
                }
                catch
                {
                    musicCD.Image = Resources.notfound;
                }

                MusicSearch.Add(musicCD);

            }
            bgl.baglanti().Close();
            getComboMusicCD(MusicSearch);
        }

        private void TxtAra_Enter(object sender, EventArgs e)
        {
            if(TxtAra.Text == "Search Something...")
            {
                TxtAra.Text = "";

                TxtAra.ForeColor = Color.Black;
            }
        }

        private void picShoppingCart_Click(object sender, EventArgs e)
        {
            ShoppingCard frm = new ShoppingCard();
            frm.Show();
           
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
