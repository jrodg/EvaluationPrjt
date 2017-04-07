using System.ComponentModel.DataAnnotations;

namespace GitHub.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}