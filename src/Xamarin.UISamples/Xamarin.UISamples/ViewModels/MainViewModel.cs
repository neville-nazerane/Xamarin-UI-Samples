using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Helpers;
using Xamarin.UISamples.Models;
using Xamarin.UISamples.Pages;
using Xamarin.UISamples.Views;

namespace Xamarin.UISamples.ViewModels
{
    public class MainViewModel
    {

        public IEnumerable<MenuData> MenuItems { get; set; }

        public MainViewModel()
        {
            MenuItems = new MenuData[] { 
                new MenuData {
                    Text = "DoorDash",
                    Command = CommandHelpers.PushPageCommand<DoorDashPage>()
                },
                new MenuData {
                    Text = "Robinhood",
                    Command = CommandHelpers.PushPageCommand<RobinhoodPage>()
                }
            };
            
        }

    }
}
