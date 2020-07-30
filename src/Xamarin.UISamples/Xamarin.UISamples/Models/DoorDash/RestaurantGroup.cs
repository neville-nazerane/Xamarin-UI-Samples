using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.UISamples.Models.DoorDash
{
    public class RestaurantGroup : List<Restaurant>
    {
        public RestaurantGroup(string title)
        {
            Title = title;
        }

        public string Title { get; set; }

    }
}
