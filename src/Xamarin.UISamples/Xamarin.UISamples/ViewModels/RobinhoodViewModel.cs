using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.UISamples.Models.Robinhood;

namespace Xamarin.UISamples.ViewModels
{
    public class RobinhoodViewModel
    {

        public IEnumerable<object> Listing { get; set; }

        public RobinhoodViewModel()
        {

            Listing = new object[]
            {
                new Popular[]
                {
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/5836/yellow-metal-design-decoration.jpg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "100 Most popular" 
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Cannabis"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/5836/yellow-metal-design-decoration.jpg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Technology"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Top movers"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Crypto"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Index ETFs"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Upcoming Earnings"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "Healthcare Supplies"
                    },
                    new Popular
                    {
                        Image = "https://images.pexels.com/photos/255379/pexels-photo-255379.jpeg?auto=compress&crop=entropy&cs=tinysrgb&dpr=2&fit=crop&h=50&w=50",
                        Text = "China"
                    }
                },
                new Card {
                    Title = "Reuters",
                    Description = "Tesla appears poised for electrifying S&P 500 debut",
                    LinkType = LinkType.Thumbnail,
                    Link = "https://cdn.vox-cdn.com/thumbor/_8W9-BYpT4-qtFafgdymfFL_BTk=/0x0:2048x1182/1200x800/filters:focal(488x541:814x867)/cdn.vox-cdn.com/uploads/chorus_image/image/66473678/EStvCm0WsAEbMCX.0.jpg",
                    Time = "2h",
                    StockChanges = new StockChange[] {
                        new StockChange
                        {
                            ShortName = "F",
                            Change = 2.65M
                        },
                        new StockChange
                        {
                            ShortName = "TSLA",
                            Change = 2.88M
                        }
                    }
                },
                new Card
                {
                    Title = "Reuters",
                    Time = "7m",
                    Description = "Exclusive: Apple is freaking killing is. Jk. apple sucks big time",
                    LinkType = LinkType.Image,
                    Link = "https://images.livemint.com/img/2020/03/03/600x338/foxconn-kht--621x414@LiveMint_1583247407320.JPG",
                    StockChanges = new StockChange[]{
                        new StockChange
                        {
                            ShortName = "AAPL",
                            Change = -0.4M
                        }
                    }
                },
                new StockChange[]
                {
                    new StockChange {
                        Name = "Matson",
                        ShortName = "MATX",
                        Change = 37.77M
                    },
                    new StockChange {
                        Name = "Osmotica Pharamaceuticals",
                        ShortName = "OSMT",
                        Change = 24.86M
                    },
                    new StockChange {
                        Name = "Urban ONe",
                        ShortName = "UONE",
                        Change = 18.07M
                    },
                    new StockChange
                    {
                        Name = "Everi",
                        ShortName = "EVRI",
                        Change = 25.11M
                    },
                    new StockChange
                    {
                        Name = "Camping World",
                        ShortName = "CWH",
                        Change = 19.85M
                    }
                },
                new Card {
                    Title = "Reuters",
                    Description = "U.S. companies seeking capital during pandemic test bank. Also, apple still sucks",
                    LinkType = LinkType.Thumbnail,
                    Link = "https://vignette.wikia.nocookie.net/rblx-jailbreak/images/6/6e/Bank_Pic.png/revision/latest/top-crop/width/360/height/360?cb=20200504023012",
                    Time = "20m",
                    StockChanges = new StockChange[]{
                        new StockChange
                        {
                            ShortName = "F",
                            Change = 3.08M
                        },
                        new StockChange
                        {
                            ShortName = "IBM",
                            Change = 1.98M
                        }
                    }
                },
                new Card
                {
                    Title = "MarketWatch",
                    Time = "1h",
                    Description = "Facebook glitch causes outrages for iOS users on Spotify, Tinder and other popular apps",
                    LinkType = LinkType.Thumbnail,
                    Link = "https://specials-images.forbesimg.com/imageserve/1191263620/960x0.jpg",
                    StockChanges = new StockChange[]{
                        new StockChange
                        {
                            ShortName = "FB",
                            Change = -1.05M
                        },
                        new StockChange
                        {
                            ShortName = "SPOT",
                            Change = 1.37M
                        }
                    }
                }
            };
        }


    }
}
