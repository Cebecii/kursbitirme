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
    public partial class urunForm : Form
    {
        public urunForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                button2.Visible = false;
                button3.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                label1.Visible = true;
                button1 .Visible = true;
                label2.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                button1.Visible = false;
                button3.Visible = false;
                button2.Visible=true;
                label1.Visible = false;
                label3.Visible=false;
                label2.Visible=true;
                comboBox1.Visible=true;
                textBox1.Visible=false;
                textBox2.Visible=false;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                button3.Visible = true;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                button2.Visible = false;
                button3.Visible = true;
                label2.Visible = true;
                comboBox1.Visible = true;
                button1.Visible = false;
            }
        }

        private void urunForm_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Silme
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //güncelle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekle
        }
    }
}
