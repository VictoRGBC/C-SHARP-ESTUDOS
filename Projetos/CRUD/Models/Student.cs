using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter ate 80 caracteres")]
        [MinLength(5, ErrorMessage = "0 nome deve conter pelo menos 5 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o E-mait")]
        [EmailAddress(ErrorMessage = "E-mail invatido")]
        [DisplayName("E-mait")]
        public string Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new ();
    }
}
