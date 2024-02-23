using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffe_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Form2 f2 = new Form2();
                   
                f2.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbKayit_CheckedChanged(object sender, EventArgs e)
        {
            cbGiris.Checked = false;
            if (cbKayit.Checked==true)
            {
                cbGiris.Visible = false;
            }
            else
            {
                cbGiris.Visible = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbGiris_CheckedChanged(object sender, EventArgs e)
        {
            cbKayit.Checked = false;
            if (cbGiris.Checked==true)
            {
                txtSifre2.Visible = false;
                btn_kayıt.Visible = false;
                label4.Visible = false;
                cbKayit.Visible = false;

            }
            else
            {
                txtSifre2.Visible = true;
                btn_kayıt.Visible = true;
                label4.Visible = true;
                cbKayit.Visible = true;
            }
        }
    }
}
