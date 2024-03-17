using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
	[Route("Events")]
	public class EventsController : Controller
	{
		static private Dictionary<string, string> Events = new Dictionary<string, string>();
		
		


		[HttpGet]
		public IActionResult Index()
		{



			ViewBag.events = Events;

			return View();
		}


		[HttpGet]
		[Route("Add")]
		public IActionResult Add()
		{
			return View();
		}


		[HttpPost]
		[Route("Add")]
		public IActionResult NewEvent(string name, string description)
		{
			Events.Add(name, description);
			return Redirect("/Events");
		}
	
		




	}
}
