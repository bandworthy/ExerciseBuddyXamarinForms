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
        //DB
        //static ExerciseAppDatabase database;

        public MainPage()
		{
			InitializeComponent();
		}

        //ADDED for DATABASE
        /*
        public static ExerciseAppDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ExerciseAppDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("ExerciseSQLite.db3"));
                }

                return database;
            }
        }
        */


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
            Navigation.PushAsync(new TTStest());
            //Navigation.RemovePage(this);
        }
    }
}
