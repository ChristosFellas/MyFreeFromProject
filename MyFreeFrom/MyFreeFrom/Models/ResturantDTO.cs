using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public int GFReviewTotal => Reviews.Sum(x => x.GfScore);
        public int GfReviewAverage => GFReviewTotal / Reviews.Where(x => x.GfScore != 0).Count();
        public int DFReviewTotal => Reviews.Sum(x => x.DfScore);
        public int DFReviewAverage => DFReviewTotal / Reviews.Where(x => x.DfScore != 0).Count();
        public int MFReviewTotal => Reviews.Sum(x => x.MfScore);
        public int MFReviewAverage => MFReviewTotal % Reviews.Where(x => x.MfScore != 0).Count();
    }
}
