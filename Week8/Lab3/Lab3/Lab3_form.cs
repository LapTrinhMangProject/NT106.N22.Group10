using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai4;
using Bai1;
using Bai3;
using Bai2;

namespace Lab3
{
    public partial class Lab3_form : Form
    {
        public Lab3_form()
        {
            InitializeComponent();
        }

        private void bai4_button_Click(object sender, EventArgs e)
        {
            new Bai4_form().Show();
        }

        private void bai1_button_Click(object sender, EventArgs e)
        {
            new Bai1_form().Show();
        }

        private void bai3_button_Click(object sender, EventArgs e)
        {
            new Bai3_form().Show();

        }

        private void bai2_button_Click(object sender, EventArgs e)
        {
            new Bai2_form().Show();
        }
    }
}
