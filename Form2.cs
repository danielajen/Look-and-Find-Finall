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
        Random box = new Random();
        int number = 0;
        int number2 = 0;
        int number3 = 0;
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
            lbltimemin.Text = minutes.ToString() + ":" + seconds;
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

            timer2.Start();


        }

        private void messii(object sender, EventArgs e)
        {
            if (number == 1 || number == 3)
            {
                //gain time for goat
                int seconds = time % 60;
                time = time + 10;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardmessi.Visible = false;
                pbcardextra.Visible = false;
            }
            if (number2 == 1 || number2 == 3)
            {
                //gain time for goat
                int seconds = time % 60;
                time = time + 10;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardmessi.Visible = false;
                pbcardextra.Visible = false;
            }
            if (number3 == 1 || number3 == 3)
            {
                //gain time for goat
                int seconds = time % 60;
                time = time + 10;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardmessi.Visible = false;
                pbcardextra.Visible = false;
            }

        }

        private void losetimelol(object sender, EventArgs e)
        {
            if (number == 2)
            {
                //lose time for ronaldo lol
                time = time - 30;
                int seconds = time % 60;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardronaldo.Visible = false;
            }
            if (number2 == 2)
            {
                //lose time for ronaldo lol
                time = time - 30;
                int seconds = time % 60;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardronaldo.Visible = false;
            }
            if (number3 == 2)
            {
                //lose time for ronaldo lol
                time = time - 30;
                int seconds = time % 60;
                int minutes = time / 60;
                lbltimemin.Text = minutes.ToString() + ":" + seconds;
                pbcardronaldo.Visible = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            number = box.Next(1, 3);
            // first one messi
            #region showpics
            if (number == 1) pbcardmessi.Image = Properties.Resources.fifa_card_powerup;
            if (number == 2) pbcardmessi.Image = Properties.Resources.ronaldopowerup;
            if (number == 3) pbcardmessi.Image = Properties.Resources.powerup2;

            #endregion

            number2 = box.Next(1, 3);
            // second one ronaldo
            #region showpics
            if (number2 == 1) pbcardronaldo.Image = Properties.Resources.fifa_card_powerup;
            if (number2 == 2) pbcardronaldo.Image = Properties.Resources.ronaldopowerup;
            if (number2 == 3) pbcardronaldo.Image = Properties.Resources.powerup2;

            #endregion
            number3 = box.Next(1, 3);
            // last goat one messi
            #region showpics
            if (number3 == 1) pbcardextra.Image = Properties.Resources.fifa_card_powerup;
            if (number3 == 2) pbcardextra.Image = Properties.Resources.ronaldopowerup;
            if (number3 == 3) pbcardextra.Image = Properties.Resources.powerup2;

            #endregion

            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

 
