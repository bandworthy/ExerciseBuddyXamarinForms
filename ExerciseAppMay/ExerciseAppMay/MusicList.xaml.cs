using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
#if __ANDROID__
using Android.Media;
using ExerciseAppMay.Droid;
#endif


namespace ExerciseAppMay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusicList : ContentPage
	{

#if __ANDROID__
        protected MediaPlayer player = new MediaPlayer();
#endif

        public MusicList ()
		{
			InitializeComponent ();

            // Get default music directory of Android device, read it file names into a list removing .mp3 
            string[] fileList;
            List<string> newlist = new List<string>();

            try
            {
                //var musicFiles = Directory.EnumerateFiles(Android.OS.Environment.DirectoryMusic, "*.mp3");
                var musicFiles = Directory.EnumerateFiles("/storage/emulated/0/Music/", "*.mp3");
                fileList = musicFiles.ToArray();

                //or do a foreach var
                foreach (var b in fileList)
                {
                    //Toast.MakeText(this, b, ToastLength.Long).Show();
                    //removing unwanted text from each song name
                    // adding to new list which will become the display array

                    string c = b;
                    c = b.Replace(".mp3", "");
                    c = c.Replace("/storage/emulated/0/Music/", "");

                    newlist.Add(c);
                }

                newlist.ToArray();


                //IListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, newlist);

                MusicListView.ItemsSource = newlist;

            }
            catch (DirectoryNotFoundException e)
            {
                // no directory
                //Toast.MakeText(this, "No Music Folder", ToastLength.Long).Show();
            }

        }
        // When item in list selected, get its string name.
        private void OnItemSelected_List(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem;
            //DisplayAlert(item.ToString(), "Selected value", "OK");
#if __ANDROID__
            StartPlayer("/storage/emulated/0/Music/"+item.ToString()+".mp3");
            var customStringXamarinWay = Android.App.Application.Context;
            GeneralController p = new GeneralController();
            p.testmethod(customStringXamarinWay);
#endif

        }

        //basic play selected song
        public void StartPlayer(String filePath)
        {
#if __ANDROID__
            if (player == null)
            {
                player = new MediaPlayer();
            }
            else
            {
                player.Reset();
                player.SetDataSource(filePath);
                player.Prepare();
                player.Start();
            }
#endif
        }
    }
}
