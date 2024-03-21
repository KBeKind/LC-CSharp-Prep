using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CodingEvents.Models
{
	public class Event
	{

		public string? Name { get; set; }
		public string? Description { get; set; }

		public string? Email { get; set; }

		public int Id { get; }
		static private int nextId = 1;

		public Event()
		{
			Id = nextId;
			nextId++;
		}

		public Event(string name, string description)
		{
			Name = name;
			Description = description;
			Id = nextId;
			nextId++;
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
