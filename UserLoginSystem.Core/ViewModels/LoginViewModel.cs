using System.ComponentModel.DataAnnotations;

namespace UserLoginSystem.Core.ViewModels
{
    public class LoginViewModel
    {
        [Required] public string Username { get; set; }
        [Required, DataType(DataType.Password)] public string Password { get; set; }
    }
}
