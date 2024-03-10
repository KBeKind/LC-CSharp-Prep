using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HelloASPDotNet.Models.ViewModels
{
	public class HelloIndexViewModel
	{
		[Required(ErrorMessage = "Please enter your name.")]
		public string Name { get; set; }
		public SelectList LanguageList { get; set; }

		[Required(ErrorMessage = "Please select a language.")]
		public string SelectedLanguage { get; set; }
	}
}
