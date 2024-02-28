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
    public partial class masalarForm : Form
    {
        public masalarForm()
        {
            InitializeComponent();
        }

        private void masalarForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a%2==0)
            {
                button1.BackColor = Color.Red;
                button1.Text = "Dolu";
            }
            else
            {
                button1.BackColor = Color.Lime;
                button1.Text = "Boş";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button2.BackColor = Color.Red;
                button2.Text = "Dolu";
            }
            else
            {
                button2.BackColor = Color.Lime;
                button2.Text = "Boş";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button3.BackColor = Color.Red;
                button3.Text = "Dolu";
            }
            else
            {
                button3.BackColor = Color.Lime;
                button3.Text = "Boş";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button4.BackColor = Color.Red;
                button4.Text = "Dolu";
            }
            else
            {
                button4.BackColor = Color.Lime;
                button4.Text = "Boş";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button5.BackColor = Color.Red;
                button5.Text = "Dolu";
            }
            else
            {
                button5.BackColor = Color.Lime;
                button5.Text = "Boş";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button6.BackColor = Color.Red;
                button6.Text = "Dolu";
            }
            else
            {
                button6.BackColor = Color.Lime;
                button6.Text = "Boş";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button7.BackColor = Color.Red;
                button7.Text = "Dolu";
            }
            else
            {
                button7.BackColor = Color.Lime;
                button7.Text = "Boş";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button8.BackColor = Color.Red;
                button8.Text = "Dolu";
            }
            else
            {
                button8.BackColor = Color.Lime;
                button8.Text = "Boş";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = 1;
            a++;
            if (a % 2 == 0)
            {
                button9.BackColor = Color.Red;
                button9.Text = "Dolu";
            }
            else
            {
                button9.BackColor = Color.Lime;
                button9.Text = "Boş";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = 1;

            a++;
            if (a % 2 == 0)
            {
                button10.BackColor = Color.Red;
                button10.Text = "Dolu";
            }
            else
            {
                button10.BackColor = Color.Lime;
                button10.Text = "Boş";
            }
        }
    }
}
