// See https://aka.ms/new-console-template for more information
using Assignment04Jenkins;

Console.WriteLine("Product Details");
Console.WriteLine($"{"PId",10}{"PName",10}{"PPrice",10}{"PBrand",10}{"Mfd",10}{"ExpDate",10}");
ProductManagement pm = new ProductManagement();
pm.AllProducts();

