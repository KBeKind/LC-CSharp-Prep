﻿using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventCategoryViewModel
	{

		[Required(ErrorMessage = "Event Name is required")]
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters long")]
		public string Name { get; set; }
	}
}
