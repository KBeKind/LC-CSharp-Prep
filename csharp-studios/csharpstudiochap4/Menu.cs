using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstudiochap4
{
	public class Menu
	{

		public string RestaurantName { get; set; }
		public List<Category> CategoryList { get; set; }

		public List<MenuItem> MenuItemList { get; set; }

		public DateTime LastUpdated { get; set; }


	}
}
