using MyFreeFrom.Entities;
using System.Collections.Generic;

namespace MyFreeFrom.Repositories
{
    public interface IResturantRepository
    {
        IEnumerable<Resturant> GetResturants();
        Resturant GetResturant(int resturantId);
        IEnumerable<Review> GetReviewsForResturant(int resturantId);
        Review GetReviewForResturant(int resturantId, int reviewId);
        void AddResturant(Resturant resturant);
        void AddReviewForResturant(int resturantId, Review review);
        void DeleteResturant(Resturant resturant);
        void DeleteReview(Review review);
        bool Save();
    }
}