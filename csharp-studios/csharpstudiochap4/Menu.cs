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

		public List<MenuItem> MenuItemList { get; set; } = new List<MenuItem>();

		public DateTime LastUpdated { get; set; }


		public void UpdateMenu(string action) {

			MenuItem aMenuItem = new MenuItem();

            Console.WriteLine("Give the description:");
			string description = Console.ReadLine();

            Console.WriteLine("Give the price in dollars");
            string price = Console.ReadLine();

			Console.WriteLine("Give the category (Appetizer, Main Course, Dessert)");
			string aCategory = Console.ReadLine();
		
			aMenuItem.Description = description;
			aMenuItem.Price = double.Parse(price);
			aMenuItem.Updated = DateTime.Now;
			switch (aCategory)
			{
				case "Appetizer":
					aMenuItem.Category = Category.Appetizer;
					break;
				case "Main Course":
					aMenuItem.Category = Category.MainCourse;
					break;
				case "Dessert":
					aMenuItem.Category = Category.Dessert;
					break;
			}

			UpdateMenu(action, aMenuItem);
		}


		public void UpdateMenu(string action, MenuItem menuItem)
		{

			if (action == "add") { 
				bool itemExists = false;

				for (int i = 0; i < MenuItemList.Count; i++)
					{
						if (MenuItemList[i].Equals(menuItem))
						{
							itemExists = true;
                        Console.WriteLine("Item already exists");
                        break;
						}
					}

					if (!itemExists)
					{
						MenuItemList.Add(menuItem);
						LastUpdated = DateTime.Now;
						Console.WriteLine("Item Added");
					}
			
			}
			else if (action == "remove")
			{
				bool itemExists = false;
				for (var i = 0; i < MenuItemList.Count; i++)
				{
					if (MenuItemList[i].Equals(menuItem))
					{
						MenuItemList.RemoveAt(i);
						LastUpdated = DateTime.Now;
						itemExists = true;
						Console.WriteLine("Item Removed");
						break;
					}
				}
                if(!itemExists)
                {
                    Console.WriteLine("Item does not exist");
                }
             
            }
		}



		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.AppendLine($"{RestaurantName} Menu Items List:");
			stringBuilder.AppendLine("*********************************************");

			foreach(MenuItem menuItem in MenuItemList)
			{
				stringBuilder.AppendLine(menuItem.ToString());
				
			}
			stringBuilder.AppendLine("*********************************************");

			return stringBuilder.ToString();
		}

	}
}
