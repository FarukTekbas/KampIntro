// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");


Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;

Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 5, UnitPrice = 35 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Update(product2);



productManager.Sum2(3, 2);
int sumResult = productManager.Sum(4, 2);
Console.WriteLine(sumResult * 2);



// int, double, bool ... değer tip
// diziler, class, abstract class, interface ... referans tip
// ref out