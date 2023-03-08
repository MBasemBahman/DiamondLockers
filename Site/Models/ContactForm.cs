using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class ContactForm
    {
        [Required]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Service { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
