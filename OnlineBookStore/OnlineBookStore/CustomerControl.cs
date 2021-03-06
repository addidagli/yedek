﻿using System;
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
    public partial class CustomerControl : Form
    {
        public CustomerControl()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Kayıt frm = new Kayıt();
            frm.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Kullanıcı Adı ve Şifre Kontrolü
            SqlCommand komut = new SqlCommand("Select * From Tbl_Customer where Username=@p1 and Password=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa frm = new Anasayfa();
                frm.control = "false";
                frm.user = txtKullaniciAdi.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(TxtSifre.UseSystemPasswordChar == false)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
        }
    }
}
