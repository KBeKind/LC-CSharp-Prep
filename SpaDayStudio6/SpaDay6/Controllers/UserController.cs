using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModels;

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
			AddUserViewModel viewModel = new AddUserViewModel();

			return View(viewModel);
        }


        [HttpPost]
        [Route("add")]
		public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
		{

          

            if(ModelState.IsValid)
            {

                if (!addUserViewModel.VerifyPassword.Equals(addUserViewModel.Password))
                {
                    ViewBag.error = "Passwords must match";
                    return View("Add", addUserViewModel);
                }

                User newUser = new User();
                newUser.Username = addUserViewModel.Username;
                newUser.Email = addUserViewModel.Email;
                newUser.Password = addUserViewModel.Password;
                newUser.DateCreated = DateTime.Now;

                return View("Index", newUser);
            }

            return View("Add", addUserViewModel);


		}

	}

}
