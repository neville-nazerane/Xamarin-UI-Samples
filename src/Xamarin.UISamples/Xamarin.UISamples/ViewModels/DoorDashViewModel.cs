using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.UISamples.Models.DoorDash;

namespace Xamarin.UISamples.ViewModels
{
    public class DoorDashViewModel
    {

        public IEnumerable<object> ListingData { get; set; }

        public DoorDashViewModel()
        {
            ListingData = new object[]
            {

                // CATEGORIES
                new FoodCategory[]
                {
                    new FoodCategory
                    {
                        Title = "Fast Food",
                        Image = "https://cdn.pixabay.com/photo/2017/02/01/11/19/cartoon-chips-2029737__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Burgers",
                        Image = "https://cdn.pixabay.com/photo/2012/04/13/01/51/hamburger-31775__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Cool Stuff",
                        Image = "https://cdn.pixabay.com/photo/2020/01/14/10/55/cartoon-4764726__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Fast Food",
                        Image = "https://cdn.pixabay.com/photo/2017/02/01/11/19/cartoon-chips-2029737__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Burgers",
                        Image = "https://cdn.pixabay.com/photo/2012/04/13/01/51/hamburger-31775__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Cool Stuff",
                        Image = "https://cdn.pixabay.com/photo/2020/01/14/10/55/cartoon-4764726__340.png"
                    },
                                        new FoodCategory
                    {
                        Title = "Burgers",
                        Image = "https://cdn.pixabay.com/photo/2012/04/13/01/51/hamburger-31775__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Cool Stuff",
                        Image = "https://cdn.pixabay.com/photo/2020/01/14/10/55/cartoon-4764726__340.png"
                    },
                    new FoodCategory
                    {
                        Title = "Fast Food",
                        Image = "https://cdn.pixabay.com/photo/2017/02/01/11/19/cartoon-chips-2029737__340.png"
                    }
                },


                // FILTERS
                new FilterInfo[]
                {
                    new FilterInfo
                    {
                        Title = "DashPass",
                    },
                    new FilterInfo
                    {
                        Title = "Over 4.5",
                        HasDropDown = true
                    },
                    new FilterInfo
                    {
                        Title = "Under 30 mins"
                    },
                    new FilterInfo
                    {
                        Title = "Pickup"
                    },
                    new FilterInfo
                    {
                        Title = "Vegetarian"
                    },
                    new FilterInfo
                    {
                        Title = "$, $$",
                        HasDropDown = true
                    },
                    new FilterInfo
                    {
                        Title = "Group Order"
                    }
                },


                // BANNERS
                new Banner[]
                {
                    new Banner
                    {
                        Title = "Deals All Summer Long",
                        Description = "Get up to %15 when you order htrough the DashPass Local Favrites carousel n stuff",
                        BackgroundColor = Color.FromHex("f5f5f5"),
                        ForegroundColor = Color.FromHex("a8a0a0"),
                        Image = "https://cdn.pixabay.com/photo/2014/11/05/15/57/salmon-518032__480.jpg"
                    },
                    new Banner
                    {
                        Title = "10% off Pickup",
                        Description = "Grap it yourself and pay no delivery or service fees",
                        BackgroundColor = Color.FromHex("bdf3c7"),
                        ForegroundColor = Color.FromHex("6a92b0"),
                        Image = "https://cdn.pixabay.com/photo/2014/08/19/12/47/bag-421456_1280.png"
                    },
                    new Banner
                    {
                        Title = "Get household essentials, like these!",
                        Description = "Walpinks",
                        BackgroundColor = Color.FromHex("ffc1b6"),
                        ForegroundColor = Color.FromHex("95495c"),
                        Image = "https://cdn.pixabay.com/photo/2019/10/26/11/24/pomegranate-4579203__480.png"
                    }
                },


                // REST A RENTS
                new RestaurantGroup("Your Favorites")
                    {
                        new Restaurant
                        {
                            Name = "Fishy fishes",
                            Image = "https://cdn.pixabay.com/photo/2014/12/22/00/03/food-576689__480.png",
                            DeliveryTime = 45,
                            DeliveryCost = 2
                        },
                        new Restaurant
                        {
                            Name = "Only Fruits",
                            Image = "https://cdn.pixabay.com/photo/2016/12/05/10/07/dish-1883501__480.png",
                            DeliveryTime = 10,
                            DeliveryCost = 4
                        },
                        new Restaurant
                        {
                            Name = "Cakes & Cakes",
                            Image = "https://cdn.pixabay.com/photo/2015/04/27/15/14/cake-742135__480.png",
                            DeliveryTime = 32,
                            DeliveryCost = 6
                        },
                        new Restaurant
                        {
                            Name = "Bake all",
                            Image = "https://cdn.pixabay.com/photo/2016/06/18/16/30/bread-1465232__480.png",
                            DeliveryTime = 40,
                            DeliveryCost = 4
                        }
                    },
                    new RestaurantGroup("Popular near you")
                    {
                        new Restaurant
                        {
                            Name = "Only Fruits",
                            Image = "https://cdn.pixabay.com/photo/2016/12/05/10/07/dish-1883501__480.png",
                            DeliveryTime = 10,
                            DeliveryCost = 4
                        },
                        new Restaurant
                        {
                            Name = "Cakes & Cakes",
                            Image = "https://cdn.pixabay.com/photo/2015/04/27/15/14/cake-742135__480.png",
                            DeliveryTime = 32,
                            DeliveryCost = 6
                        },
                        new Restaurant
                        {
                            Name = "Fishy fishes",
                            Image = "https://cdn.pixabay.com/photo/2014/12/22/00/03/food-576689__480.png",
                            DeliveryTime = 45,
                            DeliveryCost = 2
                        }
                    },
                    new RestaurantGroup("Don't bother")
                    {
                        new Restaurant
                        {
                            Name = "Bake all",
                            Image = "https://cdn.pixabay.com/photo/2016/06/18/16/30/bread-1465232__480.png",
                            DeliveryTime = 40,
                            DeliveryCost = 4
                        },
                        new Restaurant
                        {
                            Name = "Only Fruits",
                            Image = "https://cdn.pixabay.com/photo/2016/12/05/10/07/dish-1883501__480.png",
                            DeliveryTime = 10,
                            DeliveryCost = 4
                        },
                        new Restaurant
                        {
                            Name = "Cakes & Cakes",
                            Image = "https://cdn.pixabay.com/photo/2015/04/27/15/14/cake-742135__480.png",
                            DeliveryTime = 32,
                            DeliveryCost = 6
                        },
                    }

            };
        }

    }
}
