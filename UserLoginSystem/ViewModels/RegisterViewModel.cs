using System.ComponentModel.DataAnnotations;

namespace UserLoginSystem.ViewModels
{
    public class RegisterViewModel
    {
        [Required] public string Username { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Required, DataType(DataType.Password)] public string Password { get; set; }
        [DataType(DataType.Password), Compare("Password"), Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
