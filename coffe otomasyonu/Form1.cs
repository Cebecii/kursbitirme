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
        cafe_otomasyonEntities co=new cafe_otomasyonEntities();
        
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in co.login.ToList())
            {
                if (item.userName==txtUser.Text)
                {
                    if (item.password==txtPwd.Text)
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                        this.Hide();
                    }
                }
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_kayıt.Visible = false;
            txtSifre2.Visible = false;
            label4.Visible = false;    
        }

        private void cbKayit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKayit.Checked==true)
            {
                cbKayit.Checked = true;
                cbGiris.Checked = false;

                btn_kayıt.Visible = true;
                txtSifre2.Visible = true;
                label4.Visible = true;
                btn_giris.Visible = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbGiris_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGiris.Checked == true)
            {
                cbGiris.Checked = true;
                cbKayit.Checked = false;

                btn_kayıt.Visible = false;
                txtSifre2.Visible =false;
                label4.Visible = false;
                btn_giris.Visible = true;
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
