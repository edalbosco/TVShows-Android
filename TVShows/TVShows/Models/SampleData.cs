using System.Collections.Generic;
using System.Linq;

namespace TVShows.Models
{
	public static class SampleData
	{
		public static string[] Names = {
            "Pat Davies",
            "Janis Spector",
			"Regina Joplin", 		
			"Dra. Alessandra Morelle",  	
			"Margaret Whites", 	
			"Skyler Harrisson",  
			"Al Pastorius", 		
		};

		public static List<string> SocialImageGalleryItems = new List<string>() { 
			"social_album_1.jpg",
			"social_album_2.jpg",
			"social_album_3.jpg",	
			"social_album_4.jpg",
			"social_album_5.jpg",
			"social_album_6.jpg", 
			"social_album_7.jpg",
			"social_album_8.jpg",
			"social_album_9.jpg"
		};
        
		public static List<string> UsersImagesList = new List<string>() { 
			"friend_thumbnail_27.jpg",
			"friend_thumbnail_31.jpg",
			"friend_thumbnail_34.jpg",
			"alessandra.jpg",
			"friend_thumbnail_71.jpg",
			"friend_thumbnail_75.jpg",
			"friend_thumbnail_93.jpg",
		};

		public static List<string> DashboardImagesList = new List<string>() { 
			"dashboard_thumbnail_0.jpg",
			"dashboard_thumbnail_1.jpg",
			"dashboard_thumbnail_2.jpg",
			"dashboard_thumbnail_3.jpg",
			"dashboard_thumbnail_4.jpg",
			"dashboard_thumbnail_5.jpg",
			"dashboard_thumbnail_6.jpg",
			"dashboard_thumbnail_7.jpg",
			"dashboard_thumbnail_8.jpg",
		};

		public static List<string> ProductsImagesList = new List<string>() { 
			"product_item_0.jpg",
			"product_item_1.jpg",
			"product_item_2.jpg",
			"product_item_3.jpg",
			"product_item_4.jpg",
			"product_item_5.jpg",
			"product_item_6.jpg",
			"product_item_7.jpg",
		};

		public static List<User> Users = new List<User> {
			new User( Names[0], UsersImagesList[0] ),
			new User( Names[1], UsersImagesList[1] ),
			new User( Names[2], UsersImagesList[2] ),
			new User( Names[3], UsersImagesList[3] ),
			new User( Names[4], UsersImagesList[4] ),
			new User( Names[5], UsersImagesList[5] ),
			new User( Names[6], UsersImagesList[6] ),
		};

		public static List<User> Friends = Users;
        
		public static List<Message> Messages = new List<Message> {
			new Message( 
				Friends[6], 
				7, 
				true,
				"July 7",
				"Hey check this out!", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				true
			),

			new Message( 
				Friends[5], 
				3, 
				false,
				"Yesterday",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				true
			),

			new Message( 
				Friends[4], 
				1, 
				true,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				false
			),

			new Message( 
				Friends[2], 
				2, 
				true,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				false
			),

			new Message( 
				Friends[1], 
				10, 
				false,
				"3 minutes ago",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				false
			),

			new Message( 
				Friends[0], 
				5, 
				false,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				true
			),

			new Message( 
				Friends[3], 
				7, 
				false,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				false
			),

		};

        public static List<TVShow> TVShows = new List<TVShow> {
            new TVShow(
                "article_image_0.jpg",
                "article_image_0_ban.jpg",
                "Stranger Things",
                "Netflix",
                "",
                true
            ),

            new TVShow(
                "article_image_1.jpg",
                "article_image_1_ban.jpg",
                "Game of Thrones",
                "HBO",
                "Sunday 10PM",
                true
            ),

            new TVShow(
                "article_image_2.jpg",
                "article_image_2_ban.jpg",
                "Orange Is the New Black",
                "Netflix",
                "",
                true
            ),

            new TVShow(
                "article_image_3.jpg",
                "article_image_3_ban.jpg",
                "The Night Of",
                "HBO",
                "Wednesday 9PM",
                true
            ),

            new TVShow(
                "article_image_4.jpg",
                "article_image_4_ban.jpg",
                "The Walking Dead",
                "AMC",
                "Sunday 9PM",
                true
            ),

            new TVShow(
                "article_image_5.jpg",
                "article_image_5_ban.jpg",
                "Grey's Anatomy",
                "ABC",
                "Thursday 8PM",
                true
            )
        };
        
        public static List<Message> Memos = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                false
            ),
        };

        public static List<Message> Diaries = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                false
            ),
        };

        public static List<Message> Medicines = new List<Message> {
            new Message(
                Friends[5],
                7,
                true,
                "July 7",
                "Hey check this out!",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                true,
                true
            ),

            new Message(
                Friends[1],
                3,
                false,
                "Yesterday",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                true
            ),

            new Message(
                Friends[2],
                1,
                true,
                "July 7",
                "Artina is awesome...you'll love it",
                "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.",
                false,
                false
            ),
        };





        public static List<Message> Comments = Messages.GetRange( (Messages.Count() / 2), (Messages.Count() / 2));	

		public static List<User> SmallUserList = Users.GetRange( 0, 2);	

		
	}
}