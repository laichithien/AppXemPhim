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
    public partial class MoviePanel2 : UserControl
    {
        private Form activeForm = null;
        private Phim phim = null;
        public MoviePanel2()
        {
            InitializeComponent();
        }
        public MoviePanel2(Phim phim)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = (Bitmap)AppXemPhim.Resource1.ResourceManager.GetObject(phim.MOVIE_ID);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            TenPhimTiengViet.Text = phim.MOVIE_NAME;
            TenPhimTiengAnh.Text = phim.MOVIE_NAME_ENG;
            this.phim = phim;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
            DetailFilm detailFilm = new DetailFilm(phim);
            openChildForm(detailFilm);
        }
        private void CloseForm()
        {
            if (Application.OpenForms.OfType<PlayScreen>().Count() == 1)
                Application.OpenForms.OfType<PlayScreen>().First().Close();
        }
    }
}
