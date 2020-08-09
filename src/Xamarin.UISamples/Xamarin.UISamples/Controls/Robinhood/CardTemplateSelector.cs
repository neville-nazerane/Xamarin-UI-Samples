using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Models.Robinhood;

namespace Xamarin.UISamples.Controls.Robinhood
{
    public class CardTemplateSelector : DataTemplateSelector
    {

        public DataTemplate PopularTemplate { get; set; }

        public DataTemplate CardTemplate { get; set; }

        public DataTemplate TopTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case Card _:
                    return CardTemplate;
                case IEnumerable<StockChange> _:
                    return TopTemplate;
                case IEnumerable<Popular> _:
                    return PopularTemplate;
            }

            throw new InvalidCastException($"The type {item.GetType()} doesn't have a template");
        }
    }
}
