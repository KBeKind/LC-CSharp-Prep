using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEvents.ViewModels
{
	public class AddEventTagViewModel
	{

		public int EventId { get; set; }
		public Event? Event { get; set; }
		public List<SelectListItem>? Tags { get; set; }
		public int TagId { get; set; }
		
		public AddEventTagViewModel(Event anEvent, List<Tag> tagsList)
		{
			Tags = new List<SelectListItem>();
			
			foreach (var tag in tagsList)
			{
				Tags.Add(new SelectListItem
				{
					Value = tag.Id.ToString(),
					Text = tag.Name
				});
			}
			Event = anEvent;
		}

		public AddEventTagViewModel() { }


	}
}
