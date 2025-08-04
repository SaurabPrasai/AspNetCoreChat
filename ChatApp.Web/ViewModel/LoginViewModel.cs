using System.ComponentModel.DataAnnotations;

namespace ChatApp.Web.ViewModel;

public class LoginViewModel
{
    [Required]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }
}