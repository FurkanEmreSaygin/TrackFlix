namespace Trackflix.Entities.entities
{
    public class UserSeries
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int SeriesId { get; set; }
        public Series Series { get; set; } = null!;

        public DateTime AddedAt { get; set; } = DateTime.UtcNow; // Ekstra bilgi gerekiyorsa

    }
}