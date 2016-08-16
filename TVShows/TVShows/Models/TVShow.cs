using System;

namespace TVShows.Models
{
    public class TVShow
    {
        public string Poster
        {
            get;
            set;
        }

        public string Banner
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Where
        {
            get;
            set;
        }

        public string When
        {
            get;
            set;
        }

        public Boolean IsStared
        {
            get;
            set;
        }

        public TVShow(
            string poster,
            string banner,
            string title,
            string where,
            string when,
            Boolean isStared
            )
        {
            Poster = poster;
            Banner = banner;
            Where = where;
            When = when;
            Title = title;
            IsStared = isStared;
        }
    }
}