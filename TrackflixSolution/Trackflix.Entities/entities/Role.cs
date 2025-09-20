using System.ComponentModel.DataAnnotations;

namespace Trackflix.Entities.entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}