using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TransCompanyApp.Models
{
    public class Account
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя пользователя")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Имя пользователя должно быть от 3 до 16 символов")]
        public string Login { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Длина пороля должна составлять от 6 до 32 символов")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Не указан E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Avatar { get; set; }
        public string Role { get; set; }
        [Required]
        public bool Verificate { get; set; }
        [Required]
        public string Token { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
