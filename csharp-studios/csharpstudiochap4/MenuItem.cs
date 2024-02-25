using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstudiochap4
{
	public class MenuItem
	{

		public double Price { get; set; }
		public string Description { get; set; }
		public Category Category { get; set; }
		public DateTime Updated { get; set; }


		public static string GetCategoryName(Category category)
		{
			switch (category)
			{
				case Category.Appetizer:
					return "Appetizer";
				case Category.MainCourse:
					return "Main Course";
				case Category.Dessert:
					return "Dessert";
				default:
					return null;
			}
		}
	}

}
