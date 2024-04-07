using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace CodingEvents.Controllers
{
    [Authorize]
    [Route("Events")]
	public class EventsController : Controller
	{
		private EventDbContext context;

		public EventsController(EventDbContext dbContext)
		{
			context = dbContext;
		}

        [AllowAnonymous]
        [HttpGet]
		public IActionResult Index()
		{
			List<Event> events = context.Events.Include(e => e.Category).ToList();

			return View(events);
		}



		[HttpGet]
		[Route("Add")]
		public IActionResult Add()
		{
			List<EventCategory> categories = context.Categories.ToList();
			AddEventViewModel addEventViewModel = new AddEventViewModel(categories);

			return View(addEventViewModel);
		}


		[HttpPost]
		[Route("Add")]
		public IActionResult NewEvent(AddEventViewModel addEventViewModel)
		{
			if (ModelState.IsValid) {
				EventCategory theCategory = context.Categories.Find(addEventViewModel.CategoryId);
				Event newEvent = new Event
			{
				Name = addEventViewModel.Name,
				Description = addEventViewModel.Description,
				Location = addEventViewModel.Location,
				Attendees = addEventViewModel.Attendees,
				IsRegistrationRequired = addEventViewModel.IsRegistrationRequired,
				Category = theCategory

			};
				if (addEventViewModel.ContactEmail != null)
				{
					newEvent.Email = addEventViewModel.ContactEmail;
				}

			context.Events.Add(newEvent);
			context.SaveChanges();
			return Redirect("/Events");


			}

			return View("Add", addEventViewModel);
		}


		[HttpGet]
		[Route("Delete")]
		public IActionResult Delete()
		{
			ViewBag.events = context.Events.ToList();
			return View();
		}

		[HttpPost]
		[Route("Delete")]
		public IActionResult Delete(int[] eventIds)
		{
			foreach (int eventId in eventIds)
			{
				Event? theEvent = context.Events.Find(eventId);
				context.Events.Remove(theEvent);

			}
			context.SaveChanges();

			return Redirect("/Events");
		}


		[HttpGet]
		[Route("Edit/{eventId:int}")]
		public IActionResult Edit(int eventId)
		{
			Event? currentEvent = context.Events.Find(eventId);

			ViewBag.currentEvent = currentEvent;
			ViewBag.title = "Edit Event " + currentEvent.Name + "(id = " + currentEvent.Id + ")";

			return View();

		}

		[HttpPost]
		[Route("Edit")]
		public IActionResult SubmitEditEventForm(int eventId, string name, string description)
		{
			Event? currentEvent = context.Events.Find(eventId);
			currentEvent.Name = name;
			currentEvent.Description = description;
			context.SaveChanges();


			return Redirect("/Events");

		}

		[HttpGet("Detail/{id}")]
        public IActionResult Detail(int id)
		{
			Event anEvent = context.Events.Include(e => e.Category).Include(e => e.Tags).Single(e => e.Id == id);

			EventDetailViewModel viewModel = new EventDetailViewModel(anEvent);

			return View(viewModel);
		}



	}
}
