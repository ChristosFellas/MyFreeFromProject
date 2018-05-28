using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyFreeFrom.Entities;
using MyFreeFrom.Models;
using MyFreeFrom.Repositories;
using MyFreeFrom.Temp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFreeFrom.Controllers
{
    [Route("api/resturants")]
    public class ReviewsController : Controller
    {
        private IResturantRepository _resturantRepository;
        public ReviewsController(IResturantRepository resturantRepository)
        {
            _resturantRepository = resturantRepository;
        }

        [HttpGet("{resturantId}/reviews")]
        public IActionResult GetReviews(int resturantId)
        {
            var reviews = _resturantRepository.GetReviewsForResturant(resturantId);

            if (reviews == null)
                return NotFound();

            return Ok(Mapper.Map<IEnumerable<ReviewDTO>>(reviews));
        }

        [HttpGet("{resturantId}/reviews/{reviewId}", Name = "GetReview")]
        public IActionResult GetSingleReviewForResturant(int resturantId, int reviewId)
        {
            var review = _resturantRepository.GetReviewForResturant(resturantId, reviewId);

            if (review == null)
                return NotFound();

            return Ok(Mapper.Map<ReviewDTO>(review));
        }

        [HttpPost("{resturantId}/reviews")]
        public IActionResult CreateReview(int resturantId, [FromBody]  ReviewDTO review)
        {
            if (review == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest();

            var reviewEntity = Mapper.Map<Review>(review);
            _resturantRepository.AddReviewForResturant(resturantId, reviewEntity);

            if(!_resturantRepository.Save())
            {
                return StatusCode(500, "A problem happened when trying to save the entity.");
            }

            var createdReview = Mapper.Map<ReviewDTO>(reviewEntity);

            return CreatedAtRoute("GetReview", new { resturantId, reviewId = createdReview.Id } , createdReview);
        }
    }
}
