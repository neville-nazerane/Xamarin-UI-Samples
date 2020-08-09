using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Models.Robinhood;

namespace Xamarin.UISamples.Controls.Robinhood
{
    class LinkTypeToGridConverter : IValueConverter
    {

        readonly static Dictionary<LinkType, Dictionary<string, int>> mappings;

        static LinkTypeToGridConverter()
        {
            mappings = new Dictionary<LinkType, Dictionary<string, int>> {
                {
                    LinkType.Image, new Dictionary<string, int>
                    {
                        { "descriptionColSpan", 2 },
                        { "imageColSpan", 2 },
                        { "imageRow", 2 },
                        { "imageCol", 0 },
                        { "changes", 3 },
                    }
                },
                {
                    LinkType.Thumbnail, new Dictionary<string, int>
                    {
                        { "descriptionColSpan", 1 },
                        { "imageColSpan", 1 },
                        { "imageRow", 1 },
                        { "imageCol", 1 },
                        { "changes", 3 },
                    }
                }
            };
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var linkType = (LinkType)value;

            return mappings[linkType][parameter.ToString()];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
