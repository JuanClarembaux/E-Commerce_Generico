using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Generico.Models.RegisterModels
{
    public class UserRegister
    {
        [Required]
        [EmailAddress]
        public string userMail { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        [MinLength(6), MaxLength(16)]
        public string userPassword { get; set; }

        [Required]
        public string userRole { get; set; } = "Cliente";
        [Required]
        public string UserFirstName { get; set; }
        [Required]
        public string UserSurname { get; set; }
        [Required]
        public string? UserAddress { get; set; }
        [Required]
        public string? UserPhone { get; set; }
    }
}
