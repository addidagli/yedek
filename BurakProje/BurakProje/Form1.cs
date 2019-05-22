using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurakProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUret_Click(object sender, EventArgs e)
        {
            for(int i=2; i<=128; i++)
            {
                Button Btn = new Button();
                Btn.Name = "Btn" + i.ToString();
                Btn.Size = new System.Drawing.Size(15, 30);
                Btn.Text = i.ToString();
                Btn.UseVisualStyleBackColor = true;
                Btn.Tag = null;
                Btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(Btn);
            }
        }

        int durum = 0;

        private void btn_Click(object sender, EventArgs e)
        {
            Button basilan = (Button)sender;
            object o = basilan.Tag;
            if(durum==0)
            {
                basilan.BackColor = Color.Red;
                durum=1;
            }
            else
            {
                basilan.BackColor = Color.LightGray;
                durum = 0;
            }
            label2.Text = basilan.Text;
        }
     
    }
}
