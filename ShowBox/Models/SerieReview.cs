namespace ShowBox.Models
{
    public class SerieReview
    {
        public int Id { get; set; }

        // Navigation Properties
        public int ReviewId { get; set; }
        public Review? Review { get; set; }

        public int SerieId { get; set; }
        public Serie? Serie { get; set; }
    }
}
