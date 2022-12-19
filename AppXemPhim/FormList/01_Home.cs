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
    public partial class _01_Home : Form
    {
        string search = "";
        bool playList = false;
        string playListID = "";
        public _01_Home()
        {
            InitializeComponent();
            catalog.AutoScroll = true;
            load();
        }
        public _01_Home(string search)
        {
            InitializeComponent();
            catalog.AutoScroll = true;
            this.search = search;
            load();
        }
        public _01_Home(bool playList, string playListID)
        {
            InitializeComponent();
            this.playList = playList;
            this.playListID = playListID;
            load1();
        }
        public void load1()
        {
            string query = "select distinct MOVIE.MOVIE_ID, MOVIE_NAME,MOVIE_NAME_ENG,MOVIE_STATE,MOVIE_DIRECTOR,MOVIE_TIME,MOVIE_STATUS,MOVIE_LANGUAGE,MOVIE_YEAR,MOVIE_NATION,MOVIE_CATEGORY,MOVIE_ACTORS,MOVIE_STARS,MOVIE_CONTENT,MOVIE_TAGS,MOVIE_LOVE_STATUS,MOVIE_NUMBER_ACCESS from MOVIE inner join PLAYLIST_DETAIL on MOVIE.MOVIE_ID = PLAYLIST_DETAIL.MOVIE_ID where PLAYLIST_ID = '"+playListID+"'";
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
                mvp.xemButton.Click += new EventHandler(xemButton_Clicked);
                //mvp.xemButton.Click += new EventHandler(MoviePanel_Clicked);
                catalog.Controls.Add(mvp);
            }
            if (listPhim.Rows.Count == 0)
            {

            }
        }
        public void load()
        {
            string query = "select * from MOVIE where MOVIE_NAME like N'%"+search+ "%' or MOVIE_NAME_ENG like N'%" + search + "%' or MOVIE_CATEGORY like N'%" + search + "%'or MOVIE_NATION like N'%"+search+"%'";
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
                mvp.xemButton.Click += new EventHandler(xemButton_Clicked);
                //mvp.xemButton.Click += new EventHandler(MoviePanel_Clicked);
                catalog.Controls.Add(mvp);
            }
            if (listPhim.Rows.Count == 0)
            {

            }
        }
        public void xemButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
