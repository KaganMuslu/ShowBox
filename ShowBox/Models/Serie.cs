using ShowBox.Enum;

namespace ShowBox.Models
{
    public class Serie: BaseEntity
    {
        public int Id { get; set; }

        public required string Title { get; set; }
        public List<TypeEnum> Type { get; set; }
        public List<GenreEnum> Genre { get; set; }
        public float Score { get; set; }
        public int Views { get; set; }
        public bool Status { get; set; }

        // Navigation Properties
        public List<Review>? Reviews { get; set; }
    }
}
