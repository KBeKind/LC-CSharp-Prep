using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
	[Route("Events")]
	public class EventsController : Controller
	{
		
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.events = EventData.GetAll();

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
		public IActionResult NewEvent(Event newEvent)
		{

			EventData.Add(newEvent);
			return Redirect("/Events");
		}


		[HttpGet]
		[Route("Delete")]
		public IActionResult Delete()
		{
			ViewBag.events = EventData.GetAll();
			return View();
		}

		[HttpPost]
		[Route("Delete")]
		public IActionResult Delete(int[] eventIds)
		{
			foreach (int eventId in eventIds)
			{
				EventData.Remove(eventId);

			}

			return Redirect("/Events");
		}



	}
}
