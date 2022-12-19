using AppXemPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppXemPhim.FormList
{
    public partial class AddPlaylistForm : Form
    {
        int id = 0;
        Phim phim = null;    
        public AddPlaylistForm()
        {
            InitializeComponent();
        }
        public AddPlaylistForm(Phim phim)
        {
            InitializeComponent();
            this.phim = phim;
            load();
        }
        private void load()
        {
            flowLayoutPanel1.Controls.Clear();
            Data_Provider data_Provider = new Data_Provider();
            string query = "select * from PLAYLIST";
            DataTable dt = data_Provider.ExecuteQuery(query);
            id = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string playlistname = dt.Rows[i]["PLAYLIST_NAME"].ToString();
                string playlistID = dt.Rows[i]["PLAYLIST_ID"].ToString();
                PlayListPanel playlist = new PlayListPanel(playlistID, playlistname, phim);
                flowLayoutPanel1.Controls.Add(playlist);
            }
        }

        private void AddPlaylistForm_Activated(object sender, EventArgs e)
        {
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPlayList newPlayList = new NewPlayList(id);
            newPlayList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
