using System.ComponentModel.DataAnnotations;

namespace comandamancare.Models
{
    public class ContactSugestiiClienti
    { 
    

        [Required]
        [Display(Name = "Nume: ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Prenume: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Adresa e-mail invalida") ]
        [Display(Name = "Email: ")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Mesaj: ")]
        public string Message { get; set; }

    }
}