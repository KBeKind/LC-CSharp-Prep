using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
	public class AddUserViewModel
	{
		
		[Required(ErrorMessage = "Username is required")]
		[StringLength(12, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 15 characters long")]
		public string Username { get; set; }

        [Required(ErrorMessage = "Email test required")]
        [EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[StringLength(12, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 15 characters long")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Verify Password is required")]
		[StringLength(12, MinimumLength = 3, ErrorMessage = "Verify Password must be between 3 and 15 characters long")]
		public string VerifyPassword { get; set; }

	}
}
