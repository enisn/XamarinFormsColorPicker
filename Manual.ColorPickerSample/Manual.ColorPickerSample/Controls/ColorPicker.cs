using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Manual.ColorPickerSample.Controls
{
    public class ColorPicker
    {


        static readonly Color[] defaultColors = { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Purple, Color.Brown };
        /// <summary>
        /// If user cancel it, it'll return null
        /// </summary>
        /// <param name="title">Title of yor dialog</param>
        /// <param name="message">Message of your dialog</param>
        /// <param name="colors">Colors can be picked from your dialog</param>
        public static Task<Color?> GetColorAsync(string title, string message, params Color[] colors)
        {
            var cts = new TaskCompletionSource<Color?>();

            if (colors == null || colors.Length == 0) colors = defaultColors;
            var _dialogView = new ColorPickerView(title, message, colors);
            _dialogView.Picked += (s,e)=> { cts.SetResult(_dialogView.CurrentColor); PopupNavigation.PopAsync(); };
            PopupNavigation.PushAsync(new Rg.Plugins.Popup.Pages.PopupPage
            {
                Content = _dialogView
            });

            return cts.Task;
        
        }
    }
}
