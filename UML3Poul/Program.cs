// See https://aka.ms/new-console-template for more information


using UML3Poul;

IMenuCatalog catalog;
catalog = new MenuCatalog();

Pizza p1 = new Pizza(true, 1, "Vesuvio", "Tomat, Oliven, ost", 85, MenuType.Pizza);
Console.WriteLine($"Før add af pizza {catalog.Count}");
catalog.Add(p1);
Console.WriteLine($"Efter add af pizza {catalog.Count}");

//List<IMenuItem>  veganItems = catalog.FindAllVegan(MenuType.Pizza);
//foreach (IMenuItem veganItem in veganItems)
//{
//    Console.WriteLine(veganItem.PrintInfo());
//}
