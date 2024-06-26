﻿using CodingEvents.Models;
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


		[Required(ErrorMessage = "Category is required")]
		public int CategoryId { get; set; }

		public List<SelectListItem>? Categories { get; set; }

		public AddEventViewModel()
		{
		}

		public AddEventViewModel(List<EventCategory> categories)
		{
			Categories = new List<SelectListItem>();

			foreach (var category in categories)
			{
				Categories.Add(new SelectListItem
				{
					Value = category.Id.ToString(),
					Text = category.Name
				});
			}
		}


	}
}
