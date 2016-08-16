using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Models;

namespace TVShows.ViewModels
{
    public class PostsViewModel
    {
        public List<Post> PostsList
        {
            get
            {
                return SampleData.Posts;
            }
        }
    }
}
