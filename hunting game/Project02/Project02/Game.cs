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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void StartGame()
        {

            this.Hide();
            MainGame mg = new MainGame();
            mg.ShowDialog();
            this.Close();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            label1.Text += $"Hi, {PlayerName.player}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerName.difficulty = 1;
            StartGame();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PlayerName.difficulty = 2;
            StartGame();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PlayerName.difficulty = 3;
            StartGame();
        }
    }
}
