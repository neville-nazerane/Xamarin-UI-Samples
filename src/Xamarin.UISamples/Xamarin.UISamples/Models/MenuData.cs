using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.UISamples.Models
{
    public class MenuData
    {
        public string Text { get; set; }

        public ICommand Command { get; set; }

    }
}
