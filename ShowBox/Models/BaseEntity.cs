namespace ShowBox.Models
{
    // OOP ABSTRACTION (SOYUTLAMA)
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
