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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Form1 fm = new Form1();
            fm.ShowDialog();

            this.WindowState = FormWindowState.Maximized;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Width += 7;
            pictureBox2.Height += 7;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width -= 7;
            pictureBox2.Height -= 7;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {











            //iletişim bilgileri gizleniyor
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunForm urunForm = new urunForm();
            urunForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            linkLabel1.Visible=true;
            linkLabel2.Visible=true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://harunisik.unaux.com/?i=1"); 
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            masalarForm fm= new masalarForm(); 
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
