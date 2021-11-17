using System.ComponentModel.DataAnnotations;

namespace Zadanie.Models
{
    public class FormModel
    {
        [Display(Name = "Twoje imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ile potwórzyć")]
        public int HowMuch { get; set; }
    
    }
}
