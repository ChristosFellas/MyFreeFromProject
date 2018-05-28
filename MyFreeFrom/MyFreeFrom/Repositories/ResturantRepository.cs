using Microsoft.EntityFrameworkCore;
using MyFreeFrom.Database;
using MyFreeFrom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFreeFrom.Repositories
{
    public class ResturantRepository : IResturantRepository
    {
        private ResturantContext _context;

        public ResturantRepository(ResturantContext context)
        {
            _context = context;
        }
        public IEnumerable<Resturant> GetResturants(bool includeReviews)
        {
            if (includeReviews)
                return _context.Resturants
                    .Include(x => x.Reviews)
                    .Include(x => x.DietOptions)
                    .ToList();

            return _context.Resturants.ToList();
        }

        public Resturant GetResturant(int resturantId, bool includeReviews)
        {
            if (includeReviews)
                return _context.Resturants
                    .Include(x => x.Reviews)
                    .Include(x => x.DietOptions)
                    .FirstOrDefault(x => x.Id == resturantId);

            return _context.Resturants.FirstOrDefault(x => x.Id == resturantId);
        }

        public Review GetReviewForResturant(int resturantId, int reviewId)
        {
            return _context.Reviews.FirstOrDefault(x => x.Id == reviewId && x.ResturantId == resturantId);
        }

        public IEnumerable<Review> GetReviewsForResturant(int resturantId)
        {
            return _context.Reviews.Where(x => x.ResturantId == resturantId).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void AddReviewForResturant(int resturantId, Review review)
        {
            var resturant = GetResturant(resturantId, true);
            resturant.Reviews.Add(review);
        }

        public void AddResturant(Resturant resturant)
        {
            _context.Resturants.Add(resturant);
        }

        public void DeleteResturant(Resturant resturant)
        {
            _context.Resturants.Remove(resturant);
        }

        public void DeleteReview(Review review)
        {
            _context.Reviews.Remove(review);
        }
    }
}
