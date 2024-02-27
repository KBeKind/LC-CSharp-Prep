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

		public override bool Equals(object? obj)
		{
			return obj is MenuItem item &&
				   Price == item.Price &&
				   Description == item.Description &&
				   Category == item.Category;
		}

		public override string ToString()
		{
			return $"{Description} Price:{Price} \n Category:{GetCategoryName(Category)} \n Added On:{Updated}\n";
		}






	}

}
