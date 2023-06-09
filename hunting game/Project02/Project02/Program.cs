using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    static class Program
    {
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            MessageBox.Show("Program was created by  Zhanarys Malik(ID:w65398), Abdulla Avdillaev(ID:w65391), Baizhan Dossanov(ID:w63873)");
        }
    }
}
