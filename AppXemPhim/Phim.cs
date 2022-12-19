using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppXemPhim
{
    public class Phim
    {
        public string MOVIE_ID { get; set; }
        public string MOVIE_NAME { get; set; }
        public string MOVIE_NAME_ENG { get; set; }
        public string MOVIE_STATE { get; set; }
        public string MOVIE_DIRECTOR { get; set; }
        public string MOVIE_TIME { get; set; }
        public string MOVIE_STATUS { get; set; }
        public string MOVIE_LANGUAGE { get; set; }
        public string MOVIE_YEAR { get; set; }
        public string MOVIE_NATION { get; set;}
        public string MOVIE_CATEGORY { get; set; }
        public string MOVIE_ACTORS { get; set; }
        public int MOVIE_STARS { get; set; }
        public string MOVIE_CONTENT { get; set; }
        public string MOVIE_TAGS { get; set; }
        public int MOVIE_LOVE_STATUS { get; set; }
        public int MOVIE_NUMBER_ACCESS { get; set; }
        public Phim(
            string movie_id = "Unknown", 
            string movie_name = "Unknown",
            string movie_name_eng = "Unknown",
            string movie_state = "Unknown",
            string movie_director = "Unknown",
            string movie_time = "Unknown",
            string movie_status = "Unknown",
            string movie_language = "Unknown",
            string movie_year = "Unknown",
            string movie_nation = "Unknown",
            string movie_category = "Unknown",
            string movie_actors = "Unknown",
            int movie_stars = 0,
            string movie_content = "Unknown",
            string movie_tags = "Unknown",
            int movie_love_status = 0,
            int movie_number_access = 0
            )
        {
            MOVIE_ID = movie_id;
            MOVIE_NAME = movie_name;
            MOVIE_NAME_ENG = movie_name_eng;
            MOVIE_STATE = movie_state;
            MOVIE_DIRECTOR = movie_director;
            MOVIE_TIME = movie_time;
            MOVIE_STATUS = movie_status;
            MOVIE_LANGUAGE = movie_language;
            MOVIE_YEAR = movie_year;
            MOVIE_NATION = movie_nation;
            MOVIE_CATEGORY = movie_category;
            MOVIE_ACTORS = movie_actors;
            MOVIE_STARS = movie_stars;
            MOVIE_CONTENT = movie_content;
            MOVIE_TAGS = movie_tags;
            MOVIE_LOVE_STATUS = movie_love_status;
            MOVIE_NUMBER_ACCESS = movie_number_access;
        }
    }
}
