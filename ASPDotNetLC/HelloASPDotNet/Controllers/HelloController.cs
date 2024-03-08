using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers
{
	[Route("/helloworld")]
	public class HelloController : Controller
	{
		[HttpGet]
		
		public IActionResult Index()
		{
			string html = "<form method='post' action='/helloworld/welcome'><input type='text' name='name' /><input type='submit' value='Greet Me!' /></form>";
			return Content(html, "text/html");
		}

		[HttpGet("welcome/{name?}")]
		[HttpPost]
		[Route("welcome")]
		public IActionResult Welcome(string name = "Worl")
		{
			return Content($"Welcome to my app, {name}!", "text/html");
		}
	}
}
