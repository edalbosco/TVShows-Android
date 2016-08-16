using System;
using System.Collections.Generic;
using System.Linq;
using TVShows.Models;

namespace TVShows.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel() {
		}
			
		public List<string> Images {
			get{ 
				return SampleData.SocialImageGalleryItems;
			}
		}

		public List<User> Friends 
		{ 
			get
			{
				return SampleData.Friends;
			}
		}


	}
}