using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HelloASPDotNet.Models.ViewModels
{
	public class HelloIndexViewModel
	{
		[Required(ErrorMessage = "Please enter your name.")]
		[Display(Name = "Your Name")]
		public string Name { get; set; }


		[Required(ErrorMessage = "Please select a language.")]

		public string SelectedLanguage { get; set; }

		[Display(Name = "Check if this is a test.")]
		public bool IsTest { get; set; }
		
	}
}
