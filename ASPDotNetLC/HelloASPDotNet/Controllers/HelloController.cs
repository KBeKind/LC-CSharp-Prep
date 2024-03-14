using HelloASPDotNet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HelloASPDotNet.Controllers
{
	[Route("/hello")]
	public class HelloController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{

			var languageSelectItemList = new List<SelectListItem>
			{
				new SelectListItem { Text = "English" , Value = "eng"},
				new SelectListItem { Text = "Spanish" , Value = "spa"},
				new SelectListItem { Text = "Pig Latin" , Value = "pig"},
			};

			ViewBag.LanguageSelectItemList = languageSelectItemList;
			var viewModel = new HelloIndexViewModel	{};

			return View(viewModel);
		}

		//[HttpGet("welcome/{name?}")]
		[HttpPost]
		//[Route("/hello")]
		public IActionResult Welcome(HelloIndexViewModel model)
		{

			if(ModelState.IsValid)
			{
				string result = CreateMessageFromPostedFormData(model);
				HelloWelcomeViewModel viewModel = new HelloWelcomeViewModel();
				viewModel.FinishedGreeting = result;

				if (model.IsTest)
				{
					ViewBag.TestViewBag = "TEST";
				}
				else
				{
                    ViewBag.TestViewBag = "Not a test";

                }


                return View(viewModel);
			}

			return View("Index", model);

		}


		private string CreateMessageFromPostedFormData(HelloIndexViewModel model)
		{

			switch (model.SelectedLanguage)
			{
				case "pig":
					return $"ElloHa {model.Name}";
					break;
				case "spa":
					return $"Hola {model.Name}";
					break;
				default:
					return $"Hello {model.Name}";
					break;
			}

		}

	}
}
