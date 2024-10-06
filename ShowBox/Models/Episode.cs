namespace ShowBox.Models
{
    public class Episode : BaseEntity
    {
        public int Id { get; set; }

        public required string Title { get; set; }
        public string StreamLink { get; set; }

        // Navigation Properties
        public int SerieId { get; set; }
        public Serie? Serie { get; set; }
    }
}
