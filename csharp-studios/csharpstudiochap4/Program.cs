// See https://aka.ms/new-console-template for more information


using csharpstudiochap4;

Menu aMenu = new Menu();

aMenu.RestaurantName = "Dude's Restaurant";

aMenu.UpdateMenu("add");

aMenu.UpdateMenu("add");

aMenu.UpdateMenu("add");


Console.WriteLine(aMenu);

aMenu.UpdateMenu("remove");

Console.WriteLine(aMenu);