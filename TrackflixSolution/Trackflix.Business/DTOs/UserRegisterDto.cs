namespace Trackflix.Business.DTOs
{
    public class UserRegisterDto
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; } = 2; // default User
    }
}
