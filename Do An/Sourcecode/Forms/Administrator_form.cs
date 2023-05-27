using Library_football;
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
    public partial class Administrator_form : Form
    {
        public Administrator_form()
        {
            InitializeComponent();
        }
        public Administrator_form(List<League> _league)
        {
            InitializeComponent();
            this._league = _league;
        }
        List<League> _league = new List<League>();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_form_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var league in _league)
                active_leagues_listbox.Items.Add(league.name);
        }
    }
}
