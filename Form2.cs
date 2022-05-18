using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Look_and_Find_Finall
{
    public partial class Form2 : Form
    {
        int time = 120;
        public Form2()
        {
            InitializeComponent();
        }

        private void clickhair(object sender, MouseEventArgs e)
        {

        }

        private void clickchest(object sender, EventArgs e)
        {

        }

        private void clickfcblogo(object sender, EventArgs e)
        {

        }

        private void clicksocks(object sender, MouseEventArgs e)
        {

        }

        private void clicknikelogo(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimemin.Text = time.ToString();
            time--;
            if (time == -1)
            {
                timer1.Stop();
                MessageBox.Show("L! You ran outta time");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
