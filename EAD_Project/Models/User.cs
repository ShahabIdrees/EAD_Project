using System.ComponentModel.DataAnnotations;
namespace EAD_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string ConPassword { get; set; }
    }
}
