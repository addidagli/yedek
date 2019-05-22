using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class ilkEkran : Form
    {
        public ilkEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerControl frm = new CustomerControl();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminControl frm = new AdminControl();
            frm.Show();
            this.Hide();
        }
    }
}
