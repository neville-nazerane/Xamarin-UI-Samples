using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.UISamples.Models.DoorDash
{
    public class Restaurant
    {
        public string Name { get; internal set; }
        public string Image { get; internal set; }
        public int DeliveryTime { get; internal set; }
        public int DeliveryCost { get; internal set; }
    }
}
