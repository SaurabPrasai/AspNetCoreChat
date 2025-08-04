
using System.ComponentModel.DataAnnotations;
namespace ChatApp.Web.ViewModel;

public class RegisterViewModel
{
    [Required]
    public string Fullname { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }
    
}