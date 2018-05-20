using Microsoft.AspNetCore.Mvc;
using MyFreeFrom.Temp;
using System;
using System.Linq;

namespace MyFreeFrom.Controllers
{
    [Route("api/resturants")]
    public class ReviewsController : Controller
    {
        [HttpGet("{resturantId}/reviews")]
        public IActionResult GetReviews(int resturantId)
        {
            try
            {
                var resturant = ResturantsDataStore.Current.Resturants.FirstOrDefault(x => x.Id == resturantId);
                if (resturant == null)
                {
                    return NotFound();
                }

                return Ok(resturant.Reviews);

            }
            catch (Exception exception)
            {
                return StatusCode(500, "Get Reviews: A problem happened when handling your request");
            }
        }

        [HttpGet("{resturantId}/reviews/{reviewId}")]
        public IActionResult GetSingleReviewForResturant(int resturantId, int reviewId)
        {

            try
            {
                var resturant = ResturantsDataStore.Current.Resturants.FirstOrDefault(x => x.Id == resturantId);
                if (resturant == null)
                {
                    return NotFound();
                }

                var review = resturant.Reviews.FirstOrDefault(x => x.Id == reviewId);
                if (review == null)
                {
                    return NotFound();
                }

                return Ok(review);
            }
            catch ( Exception exception)
            {

                return StatusCode(500, "Get Single Review For Resturant : A problem happened when handling your request");
            }
        }
    }
}
