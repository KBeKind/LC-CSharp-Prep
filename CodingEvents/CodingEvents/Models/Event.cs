using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CodingEvents.Models
{
	public class Event
	{

		public string? Name { get; set; }
		public string? Description { get; set; }

		public string? Email { get; set; }

		public string? Location { get; set; }

		public int? Attendees { get; set; }

		public bool IsRegistrationRequired { get; set; }

		public EventType Type { get; set; }

		public int Id { get; set; }

		public Event()
		{}

		

		public override string ToString()
		{
			return Name;
		}

		public override bool Equals(object? obj)
		{
			return obj is Event @event &&
				   Id == @event.Id;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Id);
		}
	}
}
