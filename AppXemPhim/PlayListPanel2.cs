using AppXemPhim.FormList;
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
    public partial class PlayListPanel2 : UserControl
    {
        private Form activeForm = null;
        string playlistID = String.Empty;
        public PlayListPanel2()
        {
            InitializeComponent();
        }
        public PlayListPanel2(string playlistID, string playlistname)
        {
            InitializeComponent();
            label1.Text = playlistname;
            this.playlistID = playlistID;   
        }
        private void XemNgayButton_Click(object sender, EventArgs e)
        {
            _01_Home _01_Home = new _01_Home(true, playlistID);
            openChildForm(_01_Home);
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.listFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.listFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
