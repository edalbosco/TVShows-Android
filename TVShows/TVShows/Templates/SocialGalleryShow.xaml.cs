using System;
using System.Collections.Generic;
using TVShows.Models;
using TVShows.Pages;
using TVShows.ViewModels;
using Xamarin.Forms;

namespace TVShows.Templates
{
	public partial class SocialGalleryShow : ContentView
	{
	
        public static BindableProperty ShowProperty =
    BindableProperty.Create("Show", typeof(TVShow),
        typeof(SocialGalleryShow),
        null,
        defaultBindingMode: BindingMode.OneWay
    );

        public TVShow Show
        {
            get { return (TVShow)GetValue(ShowProperty); }
            set { SetValue(ShowProperty, value); }
        }

        public SocialGalleryShow()
		{			
			InitializeComponent ();
		}

		private async void OnImageTapped(Object sender, EventArgs e){
            var selectedItem = (SocialGalleryShow)sender;

            await Navigation.PushAsync(new ShowViewPage(new ShowViewModel(selectedItem.Show)));
        }
	}
}