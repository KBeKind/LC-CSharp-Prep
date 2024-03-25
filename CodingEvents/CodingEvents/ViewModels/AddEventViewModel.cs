using CodingEvents.Models;
using CodingEvents.ValidationAttributes;
using Microsoft.AspNetCore.Mvc.Rendering;
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

		[Required(ErrorMessage = "Location is required")]
		[StringLength(60, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 60 characters long")]
		public string? Location { get; set; }

		[Required(ErrorMessage = "Attendees is required")]
		[Range(1, 50, ErrorMessage = "Value must be between 1 and 50.")]
		public int? Attendees { get; set; }




		
		[Required(ErrorMessage = "You must require registration.")]
		[MustBeTrueValidation(ErrorMessage = "You must require registration.")]
		public bool IsRegistrationRequired { get; set; }


		public EventType Type { get; set; }

		public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
   {
	  new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
	  new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
	  new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString()),
	  new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString())
   };

	}
}
