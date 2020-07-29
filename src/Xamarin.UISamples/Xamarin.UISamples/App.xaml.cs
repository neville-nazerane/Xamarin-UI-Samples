using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.UISamples.Pages;

namespace Xamarin.UISamples
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });

            InitializeComponent();

            MainPage = new MainPage();
        }


    }
}
