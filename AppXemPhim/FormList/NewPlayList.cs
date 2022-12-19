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
    public partial class NewPlayList : Form
    {
        int id = 0;
        public NewPlayList()
        {
            InitializeComponent();
        }
        public NewPlayList(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void XemNgayButton_Click(object sender, EventArgs e)
        {
            string playlistname = textBox2.Text;
            if (playlistname != "")
            {
                string query = "insert into PLAYLIST values ('PL"+id.ToString("D2")+"', N'"+playlistname+"')";
                Data_Provider data_Provider = new Data_Provider();
                data_Provider.ExecuteNonQuery(query);
                MessageBox.Show("Playlist đã được tạo thành công");
                this.Dispose();
            }
        }
    }
}
