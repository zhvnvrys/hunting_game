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
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void Restart_Load(object sender, EventArgs e)
        {
            label1.Text = PlayerName.player;
            label3.Text = $"Score : {PlayerName.score}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGame mg = new MainGame();
            mg.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.ShowDialog();
            this.Hide();
        }
    }
}
