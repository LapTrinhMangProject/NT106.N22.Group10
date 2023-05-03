using Library_football;
using SQL_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Player_form : Form
    {
        public Player_form()
        {
            InitializeComponent();
        }

        private void Player_form_Load(object sender, EventArgs e)
        {
            SQL_user sqlUser = new SQL_user();
            List<Player> _player = sqlUser.Get_Players();
            foreach (Player player in _player)
            {
                list_player_listbox.Items.Add(player.name);
            }

        }
    }
}
