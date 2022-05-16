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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showdavies(object sender, EventArgs e)
        {
            show(1);
            score = score + 10;
            checkBox1.Enabled = false;
        }

        private void showkdb(object sender, EventArgs e)
        {
            show(3);
            score = score + 10;
            checkBox3.Enabled = false;
        }

        private void showson(object sender, EventArgs e)
        {
            show(5);
            score = score + 10;
            checkBox4.Enabled = false;
        }

        private void showhaaland(object sender, EventArgs e)
        {
            show(2);
            score = score + 10;
            checkBox2.Enabled = false;
        }

        private void showinsigne(object sender, EventArgs e)
        {
            show(6);
            score = score + 10;
            checkBox5.Enabled = false;
        }

        private void showgoat(object sender, EventArgs e)
        {
            show(7);
            score = score + 10;
            checkBox6.Enabled = false;
            
        }

        private void showsalah(object sender, EventArgs e)
        {
            show(8);
            score = score + 10;
            this.checkBox7.Enabled = false;
        }

        private void show(int num)
        {
            #region numbers thing
            if (num == 1) this.checkBox1.Checked = true;
            if (num == 2) this.checkBox2.Checked = true;
            if (num == 3) this.checkBox3.Checked = true;
            if (num == 4) this.checkBox8.Checked = true;
            if (num == 5) this.checkBox4.Checked = true;
            if (num == 6) this.checkBox5.Checked = true;
            if (num == 7) this.checkBox6.Checked = true;
            if (num == 8) this.checkBox7.Checked = true;
            #endregion

            else if (score >= 80)
            {
                MessageBox.Show("show pic");
                button1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region pics
            //pics
            pb1davies.Parent = pictureBox1;
            pb1davies.BackgroundImage = null;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            messi.Parent = pictureBox1;
            messi.BackgroundImage = null;
            insigne.Parent = pictureBox1;
            insigne.BackgroundImage = null;
            haaland.Parent = pictureBox1;
            haaland.BackgroundImage = null;
            Vardy.Parent = pictureBox1;
            Vardy.BackgroundImage = null;
            kdb.Parent = pictureBox1;
            kdb.BackgroundImage = null;
            son.Parent = pictureBox1;
            son.BackgroundImage = null;
            #endregion

        }

        private void showvardy(object sender, EventArgs e)
        {
            show(4);
            score = score + 10;
            checkBox8.Enabled = false;
        }
    }
    }
