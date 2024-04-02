using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CodingEvents.Controllers
{
	[Route("EventCategory")]
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


		[HttpGet]
		[Route("Create")]
		public IActionResult Create()
		{
			AddEventCategoryViewModel viewModel = new AddEventCategoryViewModel();
			return View(viewModel);
		}


		[HttpPost]
		[Route("Create")]
		public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
		{
			if (ModelState.IsValid)
			{


				EventCategory newEventCategory = new EventCategory
				{
					Name = addEventCategoryViewModel.Name,

				};
			

				context.Categories.Add(newEventCategory);
				context.SaveChanges();
				return Redirect("/EventCategory");


			}

			return View("Create", addEventCategoryViewModel);

		}

	}
}
