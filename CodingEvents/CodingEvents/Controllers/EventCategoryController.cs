using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CodingEvents.Controllers
{
	public class EventCategoryController : Controller
	{
		private EventDbContext context;

		public EventCategoryController(EventDbContext dbContext)
		{
			context = dbContext;
		}

		public IActionResult Index()
		{
			List<EventCategory> categories = context.Categories.ToList();

			return View(categories);
		}
	}
}
