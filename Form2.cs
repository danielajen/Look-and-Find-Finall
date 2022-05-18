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
            int seconds = time % 60;
            int minutes = time / 60;
            lbltimemin.Text = minutes.ToString()+":"+seconds;
            if (seconds < 10)
            {
                lbltimemin.Text = minutes.ToString() + ":0" + seconds;
            }
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
            #region
            pb1hair.Parent = pictureBox2;
            pb1hair.BackgroundImage = null;
            pb2neckchest.Parent = pictureBox2;
            pb2neckchest.BackColor = Color.Transparent;
            fcblogo5.Parent = pictureBox2;
            fcblogo5.BackgroundImage = null;
            pb3nikelogo.Parent = pictureBox2;
            pb3nikelogo.BackgroundImage = null;
            sockthing.Parent = pictureBox2;
            sockthing.BackgroundImage = null;
            #endregion


        }


    }
    }
