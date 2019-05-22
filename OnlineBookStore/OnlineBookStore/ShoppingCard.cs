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

namespace OnlineBookStore
{
    public partial class ShoppingCard : Form
    {
        public ShoppingCard()
        {
            InitializeComponent();
            Listele();
            //lbl_username.text = cs.username;
            //txt_isim.text = cs.name;
            //txt_email.text = cs.email;
            //txt_adress.text = cs.adress;
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        Customer cs = new Customer();
        ShoppingCart shopping = new ShoppingCart();
        List<Book> bookList = new List<Book>();
        List<Magazine> magazinelist = new List<Magazine>();
        List<MusicCD> musicCDlist = new List<MusicCD>();
        double totalPrice = 0;

        void Listele()
        {

            SqlCommand komut = new SqlCommand("Select * From Tbl_ShoppingCard", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            int i = 0;
            totalPrice = 0;
            bookList.Clear();
            magazinelist.Clear();
            musicCDlist.Clear();
            while (dr.Read())
            {
                int csID = Convert.ToInt16(dr[0]);
                if (csID == cs.CustomerID)
                {
                    string type = dr[1].ToString();
                    if (type == "Book")
                    {

                        SqlCommand komut2 = new SqlCommand("Select * From Tbl_Book", bgl.baglanti());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            int tblShopping = Convert.ToInt16(dr[0]);
                            int tblBook = Convert.ToInt16(dr2[0]);

                                Book book = new Book();
                                book.ID = Convert.ToUInt16(dr2[0]);
                                book.ISBN_Number = dr2[1].ToString();
                                book.Author = dr2[2].ToString();
                                book.Page = Convert.ToInt16(dr2[3]);
                                book.Publisher = dr2[4].ToString();
                                book.Name = dr2[6].ToString();
                                //try
                                //{
                                //    book.Image = Image.FromFile(Application.StartupPath + @"\Resources\BookPictures\" + dr2["Product_Name"] + ".png");
                                //}
                                //catch
                                //{
                                //    book.Image = Resources.notfound;
                                //}
                                bookList.Add(book);
                                Panel Pnl = new Panel();
                                Pnl.BackColor = Color.White;
                                Pnl.BorderStyle = BorderStyle.FixedSingle;
                                Pnl.Name = "Pnl" + i.ToString();
                                Size sz = new Size(513, 115);
                                Pnl.Size = sz;
                                Label lbl1 = new Label();
                                Label lbl2 = new Label();

                                lbl1.Name = "lbl1_" + i.ToString();
                                lbl2.Name = "lbl2_" + i.ToString();

                                lbl1.Text = book.Name;

                                Point position = new Point(119, 48);
                                lbl1.Location = position;
                                Point position2 = new Point(385, 48);
                                lbl2.Location = position2;

                                PictureBox pcbox = new PictureBox();
                                pcbox.Name = "pcbox";
                                Point position3 = new Point(4, 4);
                                pcbox.Location = position3;
                                Size sizePic = new Size(84, 105);
                                pcbox.Size = sizePic;
                                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcbox.Image = book.Image;

                                ComboBox cmbox = new ComboBox();
                                for (int j = 1; j < 9; j++)
                                {
                                    cmbox.Items.Add(j);
                                }
                                cmbox.SelectedIndex = 0;
                                Point position4 = new Point(296, 43);
                                cmbox.Location = position4;
                                Size sizeCmBox = new Size(48, 24);
                                cmbox.Size = sizeCmBox;
                                shopping.PaymentAmount = Convert.ToInt16(cmbox.Text);
                                lbl2.Text = shopping.PaymentAmount.ToString() + " TL";

                                PictureBox pcRemove = new PictureBox();
                                pcRemove.Name = "pcRemove_" + i.ToString();
                                Point position5 = new Point(475, 77);
                                pcRemove.Location = position5;
                                Size sizePicRemove = new Size(33, 33);
                                pcRemove.Size = sizePicRemove;
                                //pcRemove.Image = Resources.remove;
                                pcRemove.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcRemove.Cursor = Cursors.Hand;
                                pcRemove.Click += delegate
                                {

                                    SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Customerid=@p1", bgl.baglanti());
                                    komut3.Parameters.AddWithValue("p1", book.ID);
                                    komut3.ExecuteNonQuery();
                                    bgl.baglanti().Close();
                                    flowLayoutPanel1.Controls.Clear();
                                    Listele();
                                };

                                CheckBox chbox = new CheckBox();
                                chbox.Name = "chbox_" + i.ToString();
                                Point location6 = new Point(464, 47);
                                chbox.Location = location6;
                                chbox.UseVisualStyleBackColor = true;
                                Size sizeCheck = new Size(15, 14);
                                chbox.Size = Size;
                                chbox.Text = "Seçim";

                                Pnl.Controls.Add(lbl1);
                                Pnl.Controls.Add(lbl2);
                                Pnl.Controls.Add(pcbox);
                                //Pnl.Controls.Add(cmbox);
                                Pnl.Controls.Add(pcRemove);
                                Pnl.Controls.Add(chbox);
                                flowLayoutPanel1.Controls.Add(Pnl);
                                i++;
                           

                        }
                        bgl.baglanti().Close();
                    }
                    else if (type == "Magazine")
                    {

                        SqlCommand komut2 = new SqlCommand("Select * From Tbl_Magazine", bgl.baglanti());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            int tblShopping = Convert.ToInt16(dr[0]);
                            int tblMagazine = Convert.ToInt16(dr2[0]);
                            if (tblShopping == tblMagazine)
                            {
                                Magazine magazine = new Magazine();
                                magazine.ID = Convert.ToUInt16(dr2[0]);
                                magazine.Issue = dr2[1].ToString();
                                magazine.Type = dr2[2].ToString();
                                magazine.Name = dr2[3].ToString();

                                //try
                                //{
                                //    magazine.Image = Image.FromFile(Application.StartupPath + @"\Resources\MagazinePictures\" + dr2["Product_Name"] + ".png");
                                //}
                                //catch
                                //{
                                //    magazine.Image = Resources.notfound;
                                //}
                                magazinelist.Add(magazine);
                                Panel Pnl = new Panel();
                                Pnl.BackColor = Color.White;
                                Pnl.BorderStyle = BorderStyle.FixedSingle;
                                Pnl.Name = "Pnl" + i.ToString();
                                Size sz = new Size(513, 115);
                                Pnl.Size = sz;
                                Label lbl1 = new Label();
                                Label lbl2 = new Label();

                                lbl1.Name = "lbl1_" + i.ToString();
                                lbl2.Name = "lbl2_" + i.ToString();

                                lbl1.Text = magazine.Name;
                                lbl2.Text = magazine.Price.ToString() + " TL";

                                Point position = new Point(119, 48);
                                lbl1.Location = position;
                                Point position2 = new Point(385, 48);
                                lbl2.Location = position2;

                                PictureBox pcbox = new PictureBox();
                                pcbox.Name = "pcbox";
                                Point position3 = new Point(4, 4);
                                pcbox.Location = position3;
                                Size sizePic = new Size(84, 105);
                                pcbox.Size = sizePic;
                                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcbox.Image = magazine.Image;

                                ComboBox cmbox = new ComboBox();
                                for (int j = 1; j < 9; j++)
                                {
                                    cmbox.Items.Add(j);
                                }
                                cmbox.SelectedIndex = 0;
                                Point position4 = new Point(296, 43);
                                cmbox.Location = position4;
                                Size sizeCmBox = new Size(48, 24);
                                cmbox.Size = sizeCmBox;

                                PictureBox pcRemove = new PictureBox();
                                pcRemove.Name = "pcRemove_" + i.ToString();
                                Point position5 = new Point(475, 77);
                                pcRemove.Location = position5;
                                Size sizePicRemove = new Size(33, 33);
                                pcRemove.Size = sizePicRemove;
                                //pcRemove.Image = Resources.remove;
                                pcRemove.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcRemove.Cursor = Cursors.Hand;
                                pcRemove.Click += delegate
                                {

                                    SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Customerid=@p1", bgl.baglanti());
                                    komut3.Parameters.AddWithValue("p1", magazine.ID);
                                    komut3.ExecuteNonQuery();
                                    bgl.baglanti().Close();
                                    flowLayoutPanel1.Controls.Clear();
                                    Listele();
                                };

                                Pnl.Controls.Add(lbl1);
                                Pnl.Controls.Add(lbl2);
                                Pnl.Controls.Add(pcbox);
                                //Pnl.Controls.Add(cmbox);
                                Pnl.Controls.Add(pcRemove);
                                flowLayoutPanel1.Controls.Add(Pnl);
                                i++;
                            }
                        }
                        bgl.baglanti().Close();
                    }
                    else if (type == "Music")
                    {

                        SqlCommand komut2 = new SqlCommand("Select * From Tbl_Music", bgl.baglanti());
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        while (dr2.Read())
                        {
                            int tblShopping = Convert.ToInt16(dr[0]);
                            int tblMusic = Convert.ToInt16(dr2[0]);
                            if (tblShopping == tblMusic)
                            {
                                MusicCD musicCD = new MusicCD();
                                musicCD.ID = Convert.ToUInt16(dr2[0]);
                                musicCD.Singer = dr2[1].ToString();
                                musicCD.Type = dr2[2].ToString();
                                musicCD.Name = dr2[3].ToString();

                                //try
                                //{
                                //    musicCD.Image = Image.FromFile(Application.StartupPath + @"\Resources\MusicPictures\" + dr2["Product_Name"] + ".png");
                                //}
                                //catch
                                //{
                                //    musicCD.Image = Resources.notfound;
                                //}
                                musicCDlist.Add(musicCD);
                                Panel Pnl = new Panel();
                                Pnl.BackColor = Color.White;
                                Pnl.BorderStyle = BorderStyle.FixedSingle;
                                Pnl.Name = "Pnl" + i.ToString();
                                Size sz = new Size(513, 115);
                                Pnl.Size = sz;
                                Label lbl1 = new Label();
                                Label lbl2 = new Label();

                                lbl1.Name = "lbl1_" + i.ToString();
                                lbl2.Name = "lbl2_" + i.ToString();

                                lbl1.Text = musicCD.Name;
                                lbl2.Text = musicCD.Price.ToString() + " TL";

                                Point position = new Point(119, 48);
                                lbl1.Location = position;
                                Point position2 = new Point(385, 48);
                                lbl2.Location = position2;

                                PictureBox pcbox = new PictureBox();
                                pcbox.Name = "pcbox";
                                Point position3 = new Point(4, 4);
                                pcbox.Location = position3;
                                Size sizePic = new Size(84, 105);
                                pcbox.Size = sizePic;
                                pcbox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcbox.Image = musicCD.Image;

                                ComboBox cmbox = new ComboBox();
                                for (int j = 1; j < 9; j++)
                                {
                                    cmbox.Items.Add(j);
                                }
                                cmbox.SelectedIndex = 0;
                                Point position4 = new Point(296, 43);
                                cmbox.Location = position4;
                                Size sizeCmBox = new Size(48, 24);
                                cmbox.Size = sizeCmBox;

                                PictureBox pcRemove = new PictureBox();
                                pcRemove.Name = "pcRemove_" + i.ToString();
                                Point position5 = new Point(475, 77);
                                pcRemove.Location = position5;
                                Size sizePicRemove = new Size(33, 33);
                                pcRemove.Size = sizePicRemove;
                                //pcRemove.Image = Resources.remove;
                                pcRemove.SizeMode = PictureBoxSizeMode.StretchImage;
                                pcRemove.Cursor = Cursors.Hand;
                                pcRemove.Click += delegate
                                {

                                    SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Product_ID=@p1", bgl.baglanti());
                                    komut3.Parameters.AddWithValue("p1", musicCD.ID);
                                    komut3.ExecuteNonQuery();
                                    bgl.baglanti().Close();
                                    flowLayoutPanel1.Controls.Clear();
                                    Listele();
                                };

                                Pnl.Controls.Add(lbl1);
                                Pnl.Controls.Add(lbl2);
                                Pnl.Controls.Add(pcbox);
                                // Pnl.Controls.Add(cmbox);
                                Pnl.Controls.Add(pcRemove);
                                flowLayoutPanel1.Controls.Add(Pnl);
                                i++;
                            }
                        }
                        bgl.baglanti().Close();
                    }
                }
            }
            bgl.baglanti().Close();

            for (int k = 0; k < bookList.Count; k++)
            {
                totalPrice += bookList[k].Price;
            }
            for (int k = 0; k < magazinelist.Count; k++)
            {
                totalPrice += magazinelist[k].Price;
            }
            for (int k = 0; k < musicCDlist.Count; k++)
            {
                totalPrice += musicCDlist[k].Price;
            }
            lbl_price.Text = totalPrice.ToString();
        }

        private void ShoppingCard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Check_credit.Checked = true;
            lblprice.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Product_ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("p1", bookList[i].ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < magazinelist.Count; i++)
            {

                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Product_ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("p1", magazinelist[i].ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < musicCDlist.Count; i++)
            {

                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_ShoppingCard WHERE Product_ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("p1", musicCDlist[i].ID);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                flowLayoutPanel1.Controls.Clear();
            }
            MessageBox.Show("Shopping Succesful");
            Listele();
            lblprice.Text = totalPrice.ToString();
        }

        private void Check_credit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Check_Cash_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
