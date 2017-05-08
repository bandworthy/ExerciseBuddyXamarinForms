using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciseAppMay
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void GoExerciseButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise());
           // Navigation.RemovePage(this);
        }
        private void GoMusicListButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MusicList());
            //Navigation.RemovePage(this);
        }
        private void GoTTSButton_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new MusicList());
            //Navigation.RemovePage(this);
        }
    }
}
