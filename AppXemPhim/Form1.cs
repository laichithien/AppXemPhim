using AppXemPhim.DAO;
using AppXemPhim.FormList;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppXemPhim
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        bool sidebarExpand = false;
        string choosingScreen = "Home";
        bool theloaiExpand = false;
        bool quocgiaExpand = false;
        public Form1()
        {
            InitializeComponent();
            sidebar.Height = this.Height - 80;
            Variables.listFormPanel.ListFormsPanel.Add(mainContainer);
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            mainContainer.Controls.Clear();
            choosingScreen = "Home";
            _01_Home _01_Home = new _01_Home();
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
                MoviePanel mvp = new MoviePanel(phim);
                //mvp.xemButton.Click += new EventHandler(MoviePanel_Clicked);
                mainContainer.Controls.Add(mvp);
            }
            if (listPhim.Rows.Count == 0)
            {

            }
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                mainContainer.Width += 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                mainContainer.Width -= 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            sidebarTimer.Start();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            sidebar.Height = this.Height - 60;
            mainContainer.Height = this.Height - 60;
            mainContainer.Width = this.Width - 100;
        }
        private void Home_Click(object sender, EventArgs e)
        {
            CloseForm();
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            mainContainer.Controls.Clear();
            choosingScreen = "Home";
            _01_Home _01_Home = new _01_Home();
            openChildForm(_01_Home);
        }
        private void CloseForm()
        {
            if (Application.OpenForms.OfType<PlayScreen>().Count() == 1)
                Application.OpenForms.OfType<PlayScreen>().First().Close();
        }
        private void Favorite_Click(object sender, EventArgs e)
        {
            CloseForm();
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            choosingScreen = "Favorite";
            _02_Favorite Fav = new _02_Favorite();
            openChildForm(Fav);
        }
        private void History_Click(object sender, EventArgs e)
        {
            CloseForm();
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            choosingScreen = "History";
            _03_History _03_History = new _03_History();
            openChildForm(_03_History);
        }
        private void PlayList_Click(object sender, EventArgs e)
        {
            CloseForm();
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            choosingScreen = "PlayList";
            _04_PlayList _04_PlayList = new _04_PlayList();
            openChildForm(_04_PlayList);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                theLoaiTimer.Start();
            }
            if (quocgiaExpand)
            {
                quocgiaTimer.Start();
            }
        }

        private void theLoaiTimer_Tick(object sender, EventArgs e)
        {
            if (theloaiExpand)
            {
                theloaiPanel.Height -= 10;
                if (theloaiPanel.Height == theloaiPanel.MinimumSize.Height)
                {
                    theloaiExpand = false;
                    theLoaiTimer.Stop();
                }
            }
            else
            {
                theloaiPanel.Height += 10;
                if (theloaiPanel.Height == theloaiPanel.MaximumSize.Height)
                {
                    theloaiExpand = true;
                    theLoaiTimer.Stop();
                }
            }
        }

        private void quocgiaTimer_Tick(object sender, EventArgs e)
        {
            if (quocgiaExpand)
            {
                quocgiaPanel.Height -= 10;
                if (quocgiaPanel.Height == quocgiaPanel.MinimumSize.Height)
                {
                    quocgiaExpand = false;
                    quocgiaTimer.Stop();
                }
            }
            else
            {
                quocgiaPanel.Height += 10;
                if (quocgiaPanel.Height == quocgiaPanel.MaximumSize.Height)
                {
                    quocgiaExpand = true;
                    quocgiaTimer.Stop();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                quocgiaTimer.Start();
            }
            if (theloaiExpand)
            {
                theLoaiTimer.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            mainContainer.Controls.Clear();
            choosingScreen = "Home";
            _01_Home _01_Home = new _01_Home(textBox1.Text);
            openChildForm(_01_Home);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string filterKeyword = bt.Text;
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            mainContainer.Controls.Clear();
            choosingScreen = "Home";
            _01_Home _01_Home = new _01_Home(filterKeyword);
            openChildForm(_01_Home);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string filterKeyword = bt.Text;
            if (sidebarExpand)
            {
                sidebarTimer.Start();
                if (theloaiExpand)
                {
                    theLoaiTimer.Start();
                }
                else if (quocgiaExpand)
                {
                    quocgiaTimer.Start();
                }
            }
            mainContainer.Controls.Clear();
            choosingScreen = "Home";
            _01_Home _01_Home = new _01_Home(filterKeyword);
            openChildForm(_01_Home);
        }
    }
}
