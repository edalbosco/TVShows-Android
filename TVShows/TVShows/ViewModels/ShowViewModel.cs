using System;
using System.Collections.Generic;
using System.Linq;
using TVShows.Helpers;
using TVShows.Models;
using Xamarin.Forms;

namespace TVShows.ViewModels
{
	public class ShowViewModel
	{
		public ShowViewModel() : this(new TVShow("","","","","",false)) {
		}

		public ShowViewModel(TVShow post){
			this.TVShow = post;
        }

		public TVShow TVShow { get; private set;}

		public List<Message> Comments {
			get{ 
				return SampleData.Comments;
			}
		}
	}
}