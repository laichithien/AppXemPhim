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

namespace AppXemPhim
{
    public partial class PlayListPanel : UserControl
    {
        Phim phim = null;
        string playlistID = String.Empty;
        public PlayListPanel()
        {
            InitializeComponent();
        }
        public PlayListPanel(string playlistID, string playlistname, Phim phim)
        {
            InitializeComponent();
            label1.Text = playlistname;
            this.playlistID = playlistID;
            this.phim = phim;   
        }

        private void XemNgayButton_Click(object sender, EventArgs e)
        {
            string query = "insert into PLAYLIST_DETAIL values ('"+playlistID+"', '"+phim.MOVIE_ID+"')";
            Data_Provider data_Provider = new Data_Provider();
            data_Provider.ExecuteNonQuery(query);
        }
    }
}
