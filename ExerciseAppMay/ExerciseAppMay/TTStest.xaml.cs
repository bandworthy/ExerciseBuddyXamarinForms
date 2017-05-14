using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

#if __ANDROID__

#endif

namespace ExerciseAppMay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TTStest : ContentPage
	{
		public TTStest ()
		{
			InitializeComponent ();
		}

        private void TTS_Button_OnClicked(object sender, EventArgs e)
        {
            var text = MainEntry.Text;
            
            
        }

    }
}
