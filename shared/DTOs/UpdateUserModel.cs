namespace Shared.DTOs
{
    public class UpdateUserModel
    {
        public string Role { get; set; } // Käyttäjän rooli (esim. admin, user)
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
