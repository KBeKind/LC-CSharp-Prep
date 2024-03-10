using HelloASPDotNet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace HelloASPDotNet.Controllers
{
	[Route("/helloworld")]
	public class HelloController : Controller
	{
		[HttpGet]
		
		public IActionResult Index()
		{

			var languageDictionary = new Dictionary<string, string>
			{
				{ "eng", "English" },
				{ "spa", "Spanish" },
				{ "pig", "Pig Latin" }
			};

			var viewModel = new HelloIndexViewModel
			{
				LanguageList = new SelectList(languageDictionary, "Key", "Value")
			};


			//ViewData["LanguageList"] = new SelectList(languageDictionary ?? new Dictionary<string, string>(), "Key", "Value");
			//ViewData["LanguageList"] = new SelectList(languageDictionary, "Key", "Value" );

			return View(viewModel);
		}

		[HttpGet("welcome/{name?}")]
		[HttpPost]
		[Route("welcome")]
		public IActionResult Welcome(HelloIndexViewModel model)
		{
			if (ModelState.IsValid)
			{
				string result = CreateMessageFromPostedFormData(model);
				return Content(result, "text/html");
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
