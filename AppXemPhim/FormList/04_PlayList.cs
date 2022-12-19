﻿using AppXemPhim.DAO;
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
    public partial class _04_PlayList : Form
    {

        public _04_PlayList()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            Data_Provider data_Provider = new Data_Provider();
            string query = "select * from PLAYLIST";
            DataTable dt = data_Provider.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string playlistname = dt.Rows[i]["PLAYLIST_NAME"].ToString();
                string playlistID = dt.Rows[i]["PLAYLIST_ID"].ToString();
                PlayListPanel2 playlist = new PlayListPanel2(playlistID, playlistname);
                catalog.Controls.Add(playlist);
            }
            
            query = "select * from MOVIE";
            DataTable listPhim = null;
            listPhim = data_Provider.ExecuteQuery(query);
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
        private void _04_PlayList_ClientSizeChanged(object sender, EventArgs e)
        {
            catalog.Width = this.Width - 350;
            catalog.Height = this.Height - catalog.Location.Y;
            goiYPhanel.Height = this.Height - goiYPhanel.Location.Y;
        }
    }
}
