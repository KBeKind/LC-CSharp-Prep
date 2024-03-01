using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

//FlavorComparer comparer = new FlavorComparer();

//availableFlavors.Sort(comparer);

foreach (var flavor in availableFlavors)
{
    Console.WriteLine($"{flavor.Name} : {flavor.Allergens.Count}");
  
}

Console.WriteLine("**********************");
availableFlavors.Sort(new FlavorComparer());

foreach (var flavor in availableFlavors)
{
	Console.WriteLine($"{flavor.Name} : {flavor.Allergens.Count}");

}
Console.WriteLine("**********************");
Console.WriteLine("**********************");

foreach (var cone in availableCones)
{
    Console.WriteLine(cone);
}

Console.WriteLine("**********************");
availableCones.Sort(new ConeComparer());

foreach (var cone in availableCones)
{
	Console.WriteLine(cone);
}


// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.