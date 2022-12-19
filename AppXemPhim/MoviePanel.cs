using AppXemPhim.FormList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppXemPhim
{
    public partial class MoviePanel : UserControl
    {
        private Form activeForm = null;
        Phim phim = null;
        private string vieName { get; set; }
        private string orgName { get; set; }
        private string imgName { get; set; }
        public MoviePanel()
        {
            InitializeComponent();
        }
        public MoviePanel(Phim phim)
        {
            InitializeComponent();
            vieName = phim.MOVIE_NAME;
            orgName = phim.MOVIE_NAME_ENG;
            imgName = phim.MOVIE_ID;
            this.phim = phim;
            load();
        }
        public void load()
        {
            pictureBox1.BackgroundImage = (Bitmap)AppXemPhim.Resource1.ResourceManager.GetObject(imgName);
            vieNameLabel.Text = vieName;
            orgNameLabel.Text = orgName;
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

        private void xemButton_Click(object sender, EventArgs e)
        {
            DetailFilm detailFilm = new DetailFilm(phim);
            openChildForm(detailFilm);
        }
    }
}
