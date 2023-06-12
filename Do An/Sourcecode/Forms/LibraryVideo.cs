using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JellyFinAPI;
using VisioForge.Core.UI.WinForms;

namespace Forms
{
    public partial class LibraryVideo : Form
    {
        public LibraryVideo()
        {
            InitializeComponent();
        }

        private void LibraryVideo_Load(object sender, EventArgs e)
        {
            Jellyfin client = new Jellyfin();
            client.GetList();
            foreach (var index in Jellyfin.requestStreamItems)
            {
                listNameListbox.Items.Add(index.Key);
            }

            foreach (var index in Jellyfin.requestStreamItems)
            {
                listNameListbox.Items.Add(index.Value);
            }



        }
    }
}
