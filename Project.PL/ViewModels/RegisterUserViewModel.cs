using System.ComponentModel.DataAnnotations;

namespace Project.PL.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }



    }
}
