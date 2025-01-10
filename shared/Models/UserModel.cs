using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class UserModel
    {
        public int UserID { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        // For frontend login
        [Required]
        [MinLength(6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$", ErrorMessage = "Password must be at least 6 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string? Password { get; set; } // Made nullable
        // For backend storage
        public string? PasswordHash { get; set; } // Made nullable
        // Additional Properties Required by Backend
        public string? Address { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
