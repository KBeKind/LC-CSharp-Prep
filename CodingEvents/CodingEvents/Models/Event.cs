using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CodingEvents.Models
{
	public class Event
	{
		//testcomment

		public string? Name { get; set; }
		public string? Description { get; set; }

		public string? Email { get; set; }

		public string? Location { get; set; }

		public int? Attendees { get; set; }

		public bool IsRegistrationRequired { get; set; }

		public EventCategory Category { get; set; }
		public int CategoryId { get; set; }

		public ICollection<Tag>? Tags { get; set; }

		public int Id { get; set; }

	
		public Event()
		{ Tags = new List<Tag>(); }


        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            Email = contactEmail;
            Tags = new List<Tag>();
        }


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
