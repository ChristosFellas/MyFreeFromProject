﻿using System.Collections.Generic;
using System.Linq;

namespace MyFreeFrom.Models
{
    public class ResturantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PhoneNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public List<DietOptionDTO> DietOptions { get; set; }
        public List<ReviewDTO> Reviews { get; set; }
    }
}
