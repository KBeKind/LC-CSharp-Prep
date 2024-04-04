using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Controllers
{
    [Route("Tag")]
    public class TagController : Controller
	{
		private EventDbContext context;

		public TagController(EventDbContext dbContext)
		{
			context = dbContext;
		}

        
        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();
            return View(tags);
        }



        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
			AddTagViewModel viewModel = new AddTagViewModel();
            return View(viewModel);
        }

        [HttpPost]
		[Route("Add")]
        public IActionResult Add(AddTagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

				Tag aTag = new Tag();
				aTag.Name = viewModel.Name;
				aTag.Events = new List<Event>();

                context.Tags.Add(aTag);
                context.SaveChanges();
                return Redirect("/Tag/");
            }

            return View("Add", viewModel);
        }



        [HttpGet]
		[Route("AddEvent")]
		public IActionResult AddEvent(int id)
		{
			Event anEvent = context.Events.Find(id);
			List<Tag> theTags = context.Tags.ToList();
			AddEventTagViewModel viewModel = new AddEventTagViewModel(anEvent, theTags);
			return View(viewModel);
		}


		[HttpPost]
		[Route("AddEvent")]
		public IActionResult AddEvent(AddEventTagViewModel viewModel)
		{

			if (ModelState.IsValid)
			{
				int eventId = viewModel.EventId;
				int tagId = viewModel.TagId;

				Event anEvent = context.Events.Include(e => e.Tags).Where(e => e.Id == eventId).First();
				Tag theTag = context.Tags.Where(t => t.Id == tagId).First();

				anEvent.Tags.Add(theTag);
				context.SaveChanges();

				return Redirect("/Events/Detail/" + eventId);

			}

			return View(viewModel);
		}


        [Route("Detail")]
        public IActionResult Detail(int id)
		{
			Tag theTag = context.Tags.Include(e => e.Events).Where(t => t.Id == id).First();

			return View(theTag);
		}


	}
}
