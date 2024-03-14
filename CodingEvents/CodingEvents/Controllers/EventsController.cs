using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
	[Route("Events")]
	public class EventsController : Controller
	{
		static private List<string> Events = new List<string>();
		
		


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
		public IActionResult NewEvent(string name)
		{
			Events.Add(name);
			return Redirect("/Events");
		}
	
		




	}
}
