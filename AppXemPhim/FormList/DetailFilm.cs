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
    public partial class DetailFilm : Form
    {
        private Phim phim = null;
        private Form activeForm = null;
        int tempStar = 0;
        public DetailFilm()
        {
            InitializeComponent();
        }
        public DetailFilm(Phim phim)
        {
            InitializeComponent();
            this.phim = phim;
            Poster.BackgroundImage = (Bitmap)AppXemPhim.Resource1.ResourceManager.GetObject(phim.MOVIE_ID);
            Poster.BackgroundImageLayout = ImageLayout.Stretch;
            TenPhimTiengViet.Text = phim.MOVIE_NAME;
            TenPhimTiengAnh.Text = phim.MOVIE_NAME_ENG;

            phimStatusLabel.Text = phim.MOVIE_STATE;
            phimNationLabel.Text = phim.MOVIE_NATION;
            namSanXuatLabel.Text = phim.MOVIE_YEAR;
            ngonNguLabel.Text = phim.MOVIE_LANGUAGE;
            viewLabel.Text = phim.MOVIE_NUMBER_ACCESS.ToString();
            filmContent.Text = phim.MOVIE_CONTENT;
            tempStar = phim.MOVIE_STARS;
            setStar();
            setLoveIcon();
            load();
        }
        public void load()
        {
            string query = "select * from MOVIE";
            Data_Provider provider = new Data_Provider();
            DataTable listPhim = provider.ExecuteQuery(query);
            for (int i = 0; i < listPhim.Rows.Count; i++)
            {
                string movie_id = listPhim.Rows[i]["MOVIE_ID"].ToString();
                string movie_name = listPhim.Rows[i]["MOVIE_NAME"].ToString();
                string movie_name_eng = listPhim.Rows[i]["MOVIE_NAME_ENG"].ToString();
                string movie_state = listPhim.Rows[i]["MOVIE_STATE"].ToString();
                string movie_director = listPhim.Rows[i]["MOVIE_DIRECTOR"].ToString();
                string movie_time = listPhim.Rows[i]["MOVIE_TIME"].ToString();
                string movie_status = listPhim.Rows[i]["MOVIE_STATUS"].ToString();
                string movie_language = listPhim.Rows[i]["MOVIE_LANGUAGE"].ToString();
                string movie_year = listPhim.Rows[i]["MOVIE_YEAR"].ToString();
                string movie_nation = listPhim.Rows[i]["MOVIE_NATION"].ToString();
                string movie_category = listPhim.Rows[i]["MOVIE_CATEGORY"].ToString();
                string movie_actors = listPhim.Rows[i]["MOVIE_ACTORS"].ToString();
                int movie_stars = Convert.ToInt16(listPhim.Rows[i]["MOVIE_STARS"].ToString());
                string movie_content = listPhim.Rows[i]["MOVIE_CONTENT"].ToString();
                string movie_tags = listPhim.Rows[i]["MOVIE_TAGS"].ToString();
                int movie_love_status = Convert.ToInt16(listPhim.Rows[i]["MOVIE_LOVE_STATUS"].ToString());
                int movie_number_access = Convert.ToInt16(listPhim.Rows[i]["MOVIE_NUMBER_ACCESS"].ToString());

                Phim phim = new Phim(
                    movie_id,
                    movie_name,
                    movie_name_eng,
                    movie_state,
                    movie_director,
                    movie_time,
                    movie_status,
                    movie_language,
                    movie_year,
                    movie_nation,
                    movie_category,
                    movie_actors,
                    movie_stars,
                    movie_content,
                    movie_tags,
                    movie_love_status,
                    movie_number_access);

                MoviePanel2 mvp = new MoviePanel2(phim);
                //mvp.xemButton.Click += new EventHandler(MoviePanel_Clicked);
                goiYPhanel.Controls.Add(mvp);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //    Data_Provider data_Provider = new Data_Provider();
            //    string query = "insert into PLAYLIST_DETAIL values ('"+phim.MOVIE_ID+"')";
            //    data_Provider.ExecuteNonQuery(query);
            AddPlaylistForm addPlaylistForm = new AddPlaylistForm(phim);
            addPlaylistForm.ShowDialog();
        }

        private void XemNgayButton_Click(object sender, EventArgs e)
        {
            Data_Provider data_Provider = new Data_Provider();
            string now = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            string query = "insert into HISTORY_MOVIE_LIST values ('"+phim.MOVIE_ID+"', '"+now+"')";
            data_Provider.ExecuteNonQuery(query);
            PlayScreen playScreen = new PlayScreen(phim);
            openChildForm(playScreen);
        }

        private void DetailFilm_ClientSizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = this.Height - flowLayoutPanel1.Location.Y;
            goiYPhanel.Height = this.Height - goiYPhanel.Location.Y;
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
        private void setStar()
        {
            switch (tempStar)
            {
                case 0:
                    star1_no.Show();
                    star2_no.Show();
                    star3_no.Show();
                    star4_no.Show();
                    star5_no.Show();
                    star1_yes.Hide();
                    star2_yes.Hide();
                    star3_yes.Hide();
                    star4_yes.Hide();
                    star5_yes.Hide();
                    break;
                case 1:
                    star1_no.Hide();
                    star2_no.Show();
                    star3_no.Show();
                    star4_no.Show();
                    star5_no.Show();
                    star1_yes.Show();
                    star2_yes.Hide();
                    star3_yes.Hide();
                    star4_yes.Hide();
                    star5_yes.Hide();
                    break ;
                case 2:
                    star1_no.Hide();
                    star2_no.Hide();
                    star3_no.Show();
                    star4_no.Show();
                    star5_no.Show();
                    star1_yes.Show();
                    star2_yes.Show();
                    star3_yes.Hide();
                    star4_yes.Hide();
                    star5_yes.Hide();
                    break;
                case 3:
                    star1_no.Hide();
                    star2_no.Hide();
                    star3_no.Hide();
                    star4_no.Show();
                    star5_no.Show();
                    star1_yes.Show();
                    star2_yes.Show();
                    star3_yes.Show();
                    star4_yes.Hide();
                    star5_yes.Hide();
                    break;
                case 4:
                    star1_no.Hide();
                    star2_no.Hide();
                    star3_no.Hide();
                    star4_no.Hide();
                    star5_no.Show();
                    star1_yes.Show();
                    star2_yes.Show();
                    star3_yes.Show();
                    star4_yes.Show();
                    star5_yes.Hide();
                    break;
                case 5:
                    star1_no.Hide();
                    star2_no.Hide();
                    star3_no.Hide();
                    star4_no.Hide();
                    star5_no.Hide();
                    star1_yes.Show();
                    star2_yes.Show();
                    star3_yes.Show();
                    star4_yes.Show();
                    star5_yes.Show();
                    break;
            }
        }
        private void star1_no_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 1;
            tempStar = 1;
            setStar();
        }

        private void star2_no_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 2;
            tempStar = 2;
            setStar();
        }

        private void star3_no_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 3;
            tempStar = 3;
            setStar();
        }

        private void star4_no_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 4;
            tempStar = 4;
            setStar();
        }

        private void star5_no_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 5;
            tempStar = 5;
            setStar();
        }

        private void star1_yes_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 1;
            tempStar = 1;
            setStar();
        }

        private void star2_yes_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 2;
            tempStar = 2;
            setStar();
        }

        private void star3_yes_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 3;
            tempStar = 3;
            setStar();
        }

        private void star4_yes_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 4;
            tempStar = 4;
            setStar();
        }

        private void star5_yes_MouseEnter(object sender, EventArgs e)
        {
            //phim.MOVIE_STARS = 5;
            tempStar = 5;
            setStar();
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            tempStar = phim.MOVIE_STARS;
            setStar();
        }

        private void star1_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_STARS = tempStar;
            saveStar();
        }

        private void star2_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_STARS = tempStar;
            saveStar();
        }

        private void star3_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_STARS = tempStar;
            saveStar();
        }

        private void star4_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_STARS = tempStar;
            saveStar();
        }

        private void star5_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_STARS = tempStar;
            saveStar();
        }
        private void saveStar()
        {
            string query = "update MOVIE set MOVIE_STARS = "+phim.MOVIE_STARS+" where MOVIE_ID = '"+phim.MOVIE_ID+"'";
            Data_Provider data_Provider = new Data_Provider();
            data_Provider.ExecuteNonQuery(query);
        }

        private void heart_no_Click(object sender, EventArgs e)
        {
            phim.MOVIE_LOVE_STATUS = 1;
            Data_Provider data_Provider = new Data_Provider();
            string query = "update MOVIE set MOVIE_LOVE_STATUS = " + phim.MOVIE_LOVE_STATUS + " where MOVIE_ID = '" + phim.MOVIE_ID + "'";
            data_Provider.ExecuteNonQuery(query);
            setLoveIcon();
        }

        private void heart_yes_Click(object sender, EventArgs e)
        {
            phim.MOVIE_LOVE_STATUS = 0;
            Data_Provider data_Provider = new Data_Provider();
            string query = "update MOVIE set MOVIE_LOVE_STATUS = " + phim.MOVIE_LOVE_STATUS + " where MOVIE_ID = '" + phim.MOVIE_ID + "'";
            data_Provider.ExecuteNonQuery(query);
            setLoveIcon();
        }
        private void setLoveIcon()
        {
            if (phim.MOVIE_LOVE_STATUS == 1)
            {
                heart_yes.Show();
                heart_no.Hide();
            }
            else 
            {
                heart_yes.Hide();
                heart_no.Show();
            }
        }
    }
}
