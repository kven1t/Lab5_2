using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tmp1 = 0;
        int tmp2 = 0;
        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            tmp1 += 1;
            if (tmp1 >= 60)
            {
                tmp2++;
                tmp1 = 0;
            }

            txtSeconds.Text = tmp1.ToString();
            txtMinutes.Text = tmp2.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmrSecundomer.Enabled == true)
                tmrSecundomer.Enabled = false;
            else
                tmrSecundomer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Sbros_Click(object sender, EventArgs e)
        {
            txtSeconds.Clear();
            txtMinutes.Clear();
            tmrSecundomer.Stop();
        }
    }
}
