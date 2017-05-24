using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ExerciseAppMay
{
	public partial class App : Application
	{
        //SQLite
        static ExerciseAppDatabase database;
        //

        public App ()
		{
			//InitializeComponent();

            //MainPage = new ExerciseAppMay.MainPage();
            //MainPage = new Exercise();
            //MainPage = new MainPage();
            //MainPage = new MusicList();
            MainPage = new NavigationPage(new MainPage());
		}

        //ADDED for DATABASE
        
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
        



		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
