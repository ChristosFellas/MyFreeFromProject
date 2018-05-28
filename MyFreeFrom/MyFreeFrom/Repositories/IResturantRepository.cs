using MyFreeFrom.Entities;
using System.Collections.Generic;

namespace MyFreeFrom.Repositories
{
    public interface IResturantRepository
    {
        IEnumerable<Resturant> GetResturants(bool includeReviews);
        Resturant GetResturant(int resturantId, bool includeReviews);
        IEnumerable<Review> GetReviewsForResturant(int resturantId);
        Review GetReviewForResturant(int resturantId, int reviewId);
        void AddResturant(Resturant resturant);
        void AddReviewForResturant(int resturantId, Review review);
        bool Save();
    }
}