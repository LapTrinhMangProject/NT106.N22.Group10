using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Connection;
using Library_football;

namespace Forms
{
    public partial class League_form : Form
    {
        public League_form()
        {
            InitializeComponent();
        }

        private void find_leagues_button_Click(object sender, EventArgs e)
        {
            SQL_user sqlUser = new SQL_user();
            List<League> _league;
           _league = sqlUser.Get_Name_leagues(name_find_textbox.Text);
            list_name_leagues.Items.Clear();
            foreach( League league in _league)
            {
                list_name_leagues.Items.Add(league.name);
            }
        }
    }
}
