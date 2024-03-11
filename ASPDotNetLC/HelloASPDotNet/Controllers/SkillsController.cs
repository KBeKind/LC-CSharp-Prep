using HelloASPDotNet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloASPDotNet.Controllers
{
	[Route("/skills")]
	public class SkillsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		[HttpGet]
		[Route("form")]
		public IActionResult Form()
		{
			var viewModel = new SkillsFormViewModel{ };

			var skillsSelectOptions = new List<SelectListItem>
			{
				new SelectListItem { Text = "Awesome" , Value = "awe"},
				new SelectListItem { Text = "Decent" , Value = "dec"},
				new SelectListItem { Text = "Beginner" , Value = "beg"},
			};

			ViewData["SkillsSelectOptions"] = skillsSelectOptions;

			return View(viewModel);

		}

		[HttpPost]
		[Route("formsubmit")]
		public IActionResult FormSubmit(SkillsFormViewModel model)
		{

			if(ModelState.IsValid)
			{
                model.CSharpLevel = ConvertForDisplay(model.CSharpLevel);
                model.JavaScriptLevel = ConvertForDisplay(model.JavaScriptLevel);
                model.JavaLevel = ConvertForDisplay(model.JavaLevel);
            }
	
			return View(model);
		}



		private string ConvertForDisplay(string value)
		{

			if (value.Equals("awe"))
			{
				return "AWESOME";

			} else if (value.Equals("dec"))
			{
				return "DECENT";
			}

			return "BEGINNER";
		}


	}





}
