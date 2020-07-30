using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.UISamples.Models.DoorDash
{
    public class Banner
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public string Image { get; internal set; }
    }
}
