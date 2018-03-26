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


            if (result != null) //If result is null, user canceled to picking color
            {
                this.BindingContext = new { Color = result.Value };
            }
        }

    }
}
