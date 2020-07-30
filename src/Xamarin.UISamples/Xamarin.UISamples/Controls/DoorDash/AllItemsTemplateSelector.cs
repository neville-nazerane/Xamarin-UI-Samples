using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Models.DoorDash;

namespace Xamarin.UISamples.Controls.DoorDash
{
    public class AllItemsTemplateSelector : DataTemplateSelector
    {

        public DataTemplate CategoryTemplate { get; set; }
        public DataTemplate FilterTemplate { get; set; }
        public DataTemplate BannerTemplate { get; set; }
        public DataTemplate RestaurantTemplate { get; set; }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case IEnumerable<FoodCategory> _: return CategoryTemplate;
                case IEnumerable<FilterInfo> _: return FilterTemplate;
                case IEnumerable<Banner> _: return BannerTemplate;
                case RestaurantGroup _: return RestaurantTemplate;
                default: return null;
            }
        }
    }
}
