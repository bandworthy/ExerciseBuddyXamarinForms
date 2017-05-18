using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

#if __ANDROID__
using ExerciseAppMay.Droid;
#endif

namespace ExerciseAppMay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TTStest : ContentPage
	{

        
		public TTStest ()
		{
            string test1 = "When I walk on by";

            //InitializeComponent ();
            var speak = new Button
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            speak.Clicked += (sender, e) => {
                //DependencyService.Get<ITextToSpeech>().Speak(test1);
                sayIt(test1);
            };
            Content = speak;

 
        }

        public void sayIt(string s)
        {
            DependencyService.Get<ITextToSpeech>().Speak(s);
        }


        private void TTS_Button_OnClicked(object sender, EventArgs e)
        {

        }


    }
}
