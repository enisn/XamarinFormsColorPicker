using Manual.ColorPickerSample.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Manual.ColorPickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ChooseColor_Clicked(object sender, EventArgs e)
        {
            var result = await ColorPicker.GetColorAsync("Primary Color", "Choose a color:");

            ////You can send your custom colors as paramters like below:
            //var result = await ColorPicker.GetColorAsync("Primary Color", "Choose a color:",
            //    Color.Cyan, Color.Aqua, Color.Azure, Color.Blue, Color.BlueViolet, Color.CadetBlue);

            if (result != null) //If result is null, user canceled to picking color
            {
                this.BindingContext = new { Color = result.Value };
            }
        }

    }
}
