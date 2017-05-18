using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciseAppMay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise : ContentPage
	{
		public Exercise ()
		{
			InitializeComponent ();

            IntensityPicker.Items.Add(" Low");
            IntensityPicker.Items.Add(" Medium");
            IntensityPicker.Items.Add(" High");
            IntensityPicker.SelectedIndex = 1;


            DurationPicker.Items.Add("20 Sec");
            DurationPicker.Items.Add("25 Sec");
            DurationPicker.Items.Add("30 Sec");
            DurationPicker.Items.Add("35 Sec");
            DurationPicker.Items.Add("40 Sec");
            DurationPicker.Items.Add("50 Sec");
            DurationPicker.Items.Add("60 Sec");
            DurationPicker.SelectedIndex = 0;

            AccessoryPicker.Items.Add("None");
            AccessoryPicker.Items.Add("Noodle");
            AccessoryPicker.Items.Add("Aquatic BarBell");
            AccessoryPicker.SelectedIndex = 0;
            

        }

        private void IntensityPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           var name = IntensityPicker.Items[IntensityPicker.SelectedIndex];

            DisplayAlert(name, "Selected value", "OK");
        }

        private void DurationPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = DurationPicker.Items[DurationPicker.SelectedIndex];

#if __ANDROID__
            DisplayAlert(name, "Selected value", "OK");
#endif
        }
        private void AccessoryPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = AccessoryPicker.Items[AccessoryPicker.SelectedIndex];

            DisplayAlert(name, "Selected value", "OK");
        }

        private void CancelExerciseCreateButton_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
            //Navigation.PushAsync(new MusicList());
            //Navigation.RemovePage(this);
        }
        

    }
}
