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
                DependencyService.Get<ITextToSpeech>().Speak(test1);
            };
            Content = speak;
        }
        

        private void TTS_Button_OnClicked(object sender, EventArgs e)
        {
//            var text = MainEntry.Text;
//#if __ANDROID__
//            sendTextAndroid("Hello World I will destroy you");
//#endif

        }
        /*
        private void sendTextAndroid(string s)
        {
#if __ANDROID__
            TextToSpeechController ttsC = new TextToSpeechController();
            ttsC.callTextToSpeech(Android.App.Application.Context,s);
#endif
        }

    */

    }
}
