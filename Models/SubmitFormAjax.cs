using System.ComponentModel.DataAnnotations;

namespace comandamancare.Models
{
    public class SubmitFormAjax
    {


        [Required]
        [Display(Name = "FirstName: ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid")]
        [Display(Name = "Email: ")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Message: ")]
        public string Message { get; set; }

    }
}