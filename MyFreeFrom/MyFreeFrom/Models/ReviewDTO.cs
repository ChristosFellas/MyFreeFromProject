namespace MyFreeFrom.Models
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GfScore { get; set; }
        public int DfScore { get; set; }
        public int MfScore { get; set; }
        public int PriceRating { get; set; }
    }
}