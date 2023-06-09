using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            Nickname.Text = PlayerName.player;
            int i = PlayerName.difficulty;

            if(i == 2)
            {
                label3.Text = "9";
                timer3.Interval = 1100;
            }
            else if(i == 3)
            {
                label3.Text = "7";
                timer3.Interval = 900;
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(countd.Text);
            if (x == 1)
            {
                countdown.Stop();
                countd.Visible = false;
                timer2.Start();
                timer3.Start();


            }
            else
            {
                x -= 1;
            }

            countd.Text = x.ToString();
        }

        

        Random rnd = new Random();
        int x, y, x1, y1;

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label3.Text);
            if (i == 0)
            {
                timer2.Stop();
                timer3.Stop();

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                PlayerName.score = score.Text;

                this.Hide();
                Restart r = new Restart();
                r.ShowDialog();
                this.Close();

            }
            else
            {
                i -= 1;
                this.CenterToScreen();
            }
            label3.Text = i.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(score.Text);
            if (a < 10)
            {
                x = pictureBox1.Location.X;
                y = pictureBox1.Location.Y;
                x = rnd.Next(100, 350);
                y = rnd.Next(100, 350);
                pictureBox1.Location = new Point(x, y);
                x1 = pictureBox2.Location.X;
                y1 = pictureBox2.Location.Y;
                x1 = rnd.Next(100, 350);
                y1 = rnd.Next(100, 350);
                pictureBox2.Location = new Point(x1, y1);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (a >= 10 && a < 20)
            {
                this.CenterToScreen();
                this.Width = 750;
                this.Height = 750;
                pictureBox3.Width = 90;
                pictureBox3.Height = 90;
                pictureBox4.Width = 80;
                pictureBox4.Height = 80;

                x = pictureBox3.Location.X;
                y = pictureBox3.Location.Y;
                x = rnd.Next(100, 500);
                y = rnd.Next(100, 500);
                pictureBox3.Location = new Point(x, y);
                x1 = pictureBox4.Location.X;
                y1 = pictureBox4.Location.Y;
                x1 = rnd.Next(100, 500);
                y1 = rnd.Next(100, 500);
                pictureBox4.Location = new Point(x1, y1);
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
            else if (a >= 20 && a < 30)
            {
                this.CenterToScreen();
                this.Width = 800;
                this.Height = 800;
                pictureBox5.Width = 100;
                pictureBox5.Height = 100;
                pictureBox6.Width = 90;
                pictureBox6.Height = 90;

                x = pictureBox5.Location.X;
                y = pictureBox5.Location.Y;
                x = rnd.Next(100, 600);
                y = rnd.Next(100, 600);
                pictureBox5.Location = new Point(x, y);
                x1 = pictureBox6.Location.X;
                y1 = pictureBox6.Location.Y;
                x1 = rnd.Next(100, 600);
                y1 = rnd.Next(100, 600);
                pictureBox6.Location = new Point(x1, y1);
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
            }
            else if (a >= 30 && a < 40)
            {
                this.CenterToScreen();
                this.Width = 900;
                this.Height = 900;
                pictureBox5.Width = 110;
                pictureBox5.Height = 110;
                pictureBox6.Width = 100;
                pictureBox6.Height = 100;

                x = pictureBox5.Location.X;
                y = pictureBox5.Location.Y;
                x = rnd.Next(100, 700);
                y = rnd.Next(100, 700);
                pictureBox5.Location = new Point(x, y);
                x1 = pictureBox6.Location.X;
                y1 = pictureBox6.Location.Y;
                x1 = rnd.Next(100, 700);
                y1 = rnd.Next(100, 700);
                pictureBox6.Location = new Point(x1, y1);
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
            }
            else if (a >= 40)
            {
                this.CenterToScreen();
                this.Width = 1000;
                this.Height = 1000;
                pictureBox5.Width = 120;
                pictureBox5.Height = 120;
                pictureBox6.Width = 110;
                pictureBox6.Height = 110;

                x = pictureBox5.Location.X;
                y = pictureBox5.Location.Y;
                x = rnd.Next(100, 750);
                y = rnd.Next(100, 750);
                pictureBox5.Location = new Point(x, y);
                x1 = pictureBox6.Location.X;
                y1 = pictureBox6.Location.Y;
                x1 = rnd.Next(100, 750);
                y1 = rnd.Next(100, 750);
                pictureBox6.Location = new Point(x1, y1);
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
            }
        }
        

        
        
        
        
        
        
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox1.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time = time + 10;
                label3.Text = time.ToString();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox2.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time = time + 10;
                label3.Text = time.ToString();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox3.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time = time + 10;
                label3.Text = time.ToString();
            }
        }

        private void countd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox4.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time = time + 10;
                label3.Text = time.ToString();
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox5.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time += 10;
                label3.Text = time.ToString();
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(score.Text);
            x++;
            score.Text = x.ToString();

            pictureBox6.Visible = false;

            if (score.Text.EndsWith("0") == true)
            {
                int time = Convert.ToInt32(label3.Text);
                time = time + 10;
                label3.Text = time.ToString();
            }
        }

    }
}
