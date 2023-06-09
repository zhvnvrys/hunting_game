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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playername.Text != "")
            {
                this.Hide();
                Settings game = new Settings();
                PlayerName.player = playername.Text;
                game.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please, Enter any nickname");
            }
        }
           
    
    
    }
}
