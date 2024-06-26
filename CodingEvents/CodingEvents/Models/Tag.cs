﻿using System.ComponentModel.DataAnnotations;

namespace CodingEvents.Models
{
	public class Tag
	{

		public int Id { get; set; }

        public string Name { get; set; }

		public ICollection<Event>? Events { get; set; }

	


		public Tag() { }

		public Tag(string name)
		{
			Name = name;
			Events = new List<Event>();
		}


	}
}
