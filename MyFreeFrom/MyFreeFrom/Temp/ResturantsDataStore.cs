using MyFreeFrom.Models;
using MyFreeFrom.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFreeFrom.Temp
{
    public class ResturantsDataStore
    {
        public List<ResturantDTO> Resturants { get; set; }

        public ResturantsDataStore()
        {
            Resturants = new List<ResturantDTO>()
            {
                new ResturantDTO(){
                    Id = 1,
                    Name = "Nando's",
                    Description = "Portugese Chicken Resturant",
                    Latitude = "0.13532",
                    Longitude = "1.4568",
                    Address = "25 Wherry Road",
                    Address2 = "Riverside Entertainment Complex",
                    City = "Norwich",
                    County = "Norfolk",
                    PhoneNumber = "01603 345234",
                    WebsiteUrl = "www.nandos.co.uk",
                    DietOptions = new List<DietOptionDTO>()
                    {
                        new DietOptionDTO()
                        {
                            Id = 1,
                            DietType = DietTypeEnum.GlutenFree
                        },
                        new DietOptionDTO()
                        {
                            Id = 2,
                            DietType = DietTypeEnum.DairyFree
                        }
                    },
                    Reviews = new List<ReviewDTO>()
                    {
                        new ReviewDTO()
                        {
                            Id = 1,
                            Title = "Gluten Free Heaven",
                            Description = "As it's chicken, this is a perfect place for some gluten and dairy free goodness",
                            GfScore = 5,
                            DfScore = 5,
                            MfScore = 0,
                            PriceRating = 2
                        },
                        new ReviewDTO()
                        {
                            Id = 2,
                            Title = "Hope you like chicken",
                            Description = "Great for all intolerences, but variety is not there as it specialises in chicken dishes.",
                            GfScore = 3,
                            DfScore = 3,
                            MfScore = 0,
                            PriceRating = 3
                        },
                        new ReviewDTO()
                        {
                            Id = 3,
                            Title = "Had Better",
                            Description = "Chicken was tough and boring",
                            GfScore = 2,
                            DfScore = 4,
                            MfScore = 0,
                            PriceRating = 4
                        },
                        new ReviewDTO()
                        {
                            Id = 4,
                            Title = "Cant beat a cheeky nandos.",
                            Description = "always my go to spot for gluten free goodness, but the prices are rising",
                            GfScore = 4,
                            DfScore = 4,
                            MfScore = 0,
                            PriceRating = 5
                        }

                    }
                },
                new ResturantDTO(){
                    Id = 2,
                    Name = "Cafe Maine",
                    Description = "Bistro Cafe",
                    Latitude = "0.1222",
                    Longitude = "1.43368",
                    Address = "25 Cromer Road",
                    Address2 = "Sheringham",
                    City = "Norwich",
                    County = "Norfolk",
                    PhoneNumber = "01603 322334",
                    WebsiteUrl = "www.cafemaine.co.uk",
                    DietOptions = new List<DietOptionDTO>()
                    {
                        new DietOptionDTO()
                        {
                            Id = 1,
                            DietType = DietTypeEnum.GlutenFree
                        },
                        new DietOptionDTO()
                        {
                            Id = 2,
                            DietType = DietTypeEnum.DairyFree
                        },
                        new DietOptionDTO()
                        {
                            Id = 3,
                            DietType = DietTypeEnum.MeatFree
                        }
                    },
                    Reviews = new List<ReviewDTO>()
                    {
                        new ReviewDTO()
                        {
                            Id = 1,
                            Title = "Very bad",
                            Description = "No Choice",
                            GfScore = 1,
                            DfScore = 1,
                            MfScore = 2,
                            PriceRating = 4
                        },
                        new ReviewDTO()
                        {
                            Id = 2,
                            Title = "good location and food",
                            Description = "cheap and cheerfull in a nice place",
                            GfScore = 4,
                            DfScore = 4,
                            MfScore = 3,
                            PriceRating = 3
                        },
                        new ReviewDTO()
                        {
                            Id = 3,
                            Title = "Seen Worse cafe's",
                            Description = "we got what we paid for",
                            GfScore = 3,
                            DfScore = 3,
                            MfScore = 3,
                            PriceRating = 3
                        },
                        new ReviewDTO()
                        {
                            Id = 4,
                            Title = "Top Service and good options",
                            Description = "cant go wrong, options for everyone and good staff and service",
                            GfScore = 4,
                            DfScore = 4,
                            MfScore = 5,
                            PriceRating = 4
                        }
                    }
                }
            };

        }
    }
}
