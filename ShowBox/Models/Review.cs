namespace ShowBox.Models
{
    public class Review: BaseEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Message { get; set; }

        // Navigation Properties
        public int SerieId { get; set; }
        public Serie? Serie { get; set; }
    }
}
