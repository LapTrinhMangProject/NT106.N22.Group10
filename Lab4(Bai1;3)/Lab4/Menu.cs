using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
        }

        private void bt_Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
