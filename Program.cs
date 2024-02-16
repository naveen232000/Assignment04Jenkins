// See https://aka.ms/new-console-template for more information
using Assignment04Jenkins;

Console.WriteLine("Product Details");
Console.WriteLine($"{"PId",-10}{"PName",-20}{"PPrice",-15}{"PBrand",-20}{"Mfd",-30}{"ExpDate",-30}");
ProductManagement pm = new ProductManagement();
Console.WriteLine();
Console.WriteLine("Before Adding New Product");
pm.AllProducts();
pm.AddNewProduct(6, "Ballpoint Pens", 50.50, "Cello", new DateTime(day: 20, month: 11, year: 2023), new DateTime(day: 20, month: 11, year: 2024));
Console.WriteLine();
Console.WriteLine("After Adding New Product");
pm.AllProducts();
