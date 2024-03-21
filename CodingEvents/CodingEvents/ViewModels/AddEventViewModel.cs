using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventViewModel
	{
		[Required(ErrorMessage = "Event Name is required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters long")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Description is required")]
		[StringLength(60, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 60 characters long")]
		public string? Description { get; set; }

		[EmailAddress]
		public string? ContactEmail { get; set; }

	}
}
