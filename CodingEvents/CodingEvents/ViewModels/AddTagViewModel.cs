using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddTagViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }


        public AddTagViewModel() { }


    }
}
