using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate
{
    public partial class Form_Verify : Form
    {
        public Form_Verify()
        {
            InitializeComponent();
        }

        private void bt_Verify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_OTP.Text)) MessageBox.Show("Vui lòng điển đầy đủ mã OTP!");
            else
            {
                if (ShareVariable.OTP == tb_OTP.Text.ToString())
                {
                    Form_ResetPass rp = new Form_ResetPass();
                    this.Hide();
                    rp.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Mã OTP bạn vừa nhập bị sai!");
                }
            }
        }
    }
}
