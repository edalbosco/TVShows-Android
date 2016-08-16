using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVShows.Models;
using Xamarin.Forms;

namespace TVShows.Pages
{
    public partial class MainPage : TabbedPage
    {

        private Command moreShowsCommand;

        ObservableCollection<ImageSource> _images;
        int idx;

        public MainPage()
        {
            InitializeComponent();

            MoreShowsCommand = new Command(MoreShows);

            idx = 2;

            BindingContext = this;
        }

        private void MoreShows(object obj)
        {
            App.Current.Navigation.PushAsync(new WebPage());
        }

        public Command MoreShowsCommand
        {
            get
            {
                return moreShowsCommand;
            }

            set
            {
                moreShowsCommand = value; OnPropertyChanged();
            }
        }

        public List<TVShow> TVShows
        {
            get
            {
                return SampleData.TVShows;
            }
        }

        public List<TVShow> Favorites
        {
            get
            {
                return new List<TVShow>() {
                    SampleData.TVShows[0],
                    SampleData.TVShows[3],
                    SampleData.TVShows[4],
                };
            }
        }

        public ObservableCollection<ImageSource> Images
        {
            get
            {
                return _images;
            }

            set
            {
                _images = value; OnPropertyChanged();
            }
        }

        public async void Handle_FabClicked(object sender, System.EventArgs e)
        {
            //colocar a mensagem e imagens.
            await DisplayAlert("", "Here the application will allow the user to choose a picture from the galery", "Close");

            idx++;

            switch (idx)
            {
                case 0: Img0.IsVisible = true; break;
                case 1: Img1.IsVisible = true; break;
                case 2: Img2.IsVisible = true; break;
                case 3: Img3.IsVisible = true; break;
                case 4: Img4.IsVisible = true; break;
                case 5: Img5.IsVisible = true; break;
                case 6: Img6.IsVisible = true; break;
                case 7: Img7.IsVisible = true; break;
                case 8: Img8.IsVisible = true; break;
            }

        }

        public async void OnItemTapped(object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var post = (TVShow)selectedItem;
            var articleView = new ShowViewPage(new ViewModels.ShowViewModel(post));
            try
            {
                await App.Current.Navigation.PushAsync(articleView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
