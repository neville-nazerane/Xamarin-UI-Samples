using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Helpers;
using Xamarin.UISamples.Models;
using Xamarin.UISamples.Pages;

namespace Xamarin.UISamples.ViewModels
{
    public class MainViewModel
    {

        public IEnumerable<MenuData> MenuItems { get; set; }

        public MainViewModel()
        {
            MenuItems = new MenuData[] { 

                new MenuData{
                    Text = "Hello",
                    Command = CommandHelpers.PushPageCommand<MainPage>()
                },
                new MenuData{
                    Text = "Bye",
                    Command = CommandHelpers.PushPageCommand<Otherpage>()
                }
                
            };
            
        }

    }
}
