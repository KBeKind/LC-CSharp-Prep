using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

namespace SpaDay6.Controllers
{
	[Route("/user")]
    public class UserController : Controller
    {

        public IActionResult Index() { return View(); }
       

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [Route("add")]
		public IActionResult SubmitAddUserForm(User newUser, string verify)
		{
			// add form submission handling code here

            if(newUser.Password.Equals(verify))
            {
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                newUser.DateCreated = DateTime.Now;

                ViewBag.dateCreated = newUser.DateCreated.ToString();


                return View("Index");
            }


            ViewBag.error = "Passwords must match";
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;

            return View("Add");


		}

	}

}
