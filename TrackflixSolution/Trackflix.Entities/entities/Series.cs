namespace Trackflix.Entities.entities
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ExternalId { get; set; } = null!; // API'den gelen id
        public virtual ICollection<UserSeries> UserFavorites { get; set; } = new List<UserSeries>();
    }

}