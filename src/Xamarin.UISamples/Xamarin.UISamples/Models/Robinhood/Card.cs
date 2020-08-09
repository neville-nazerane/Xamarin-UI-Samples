using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.UISamples.Models.Robinhood
{
    public class Card
    {

        public string Title { get; set; }

        public string Header { get; set; }

        public string Time { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public LinkType LinkType { get; set; }

        public IEnumerable<StockChange> StockChanges { get; set; }

    }
}
