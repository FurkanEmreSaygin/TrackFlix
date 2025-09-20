
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Trackflix.Entities.entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MaxLength(255), MinLength(8)]
        public int PasswordHash { get; set; }
        public int RoleId { get; set; }
        // Navigation property

        // Navigation property (one-to-many)
        public virtual Role Role { get; set; }
        // Many-to-many için explicit join kullanacağız (UserSeries)
        public virtual ICollection<UserSeries> Favorites { get; set; } = new List<UserSeries>();
    }
}