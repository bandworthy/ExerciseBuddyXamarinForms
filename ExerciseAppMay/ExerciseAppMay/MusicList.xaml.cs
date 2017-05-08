using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;


namespace ExerciseAppMay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusicList : ContentPage
	{



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
	}
}
