using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace CodingEvents.Models
{
	public class EventCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public EventCategory() {}

		public EventCategory(string aName)
		{
			Name = aName;
		}


	}
}
