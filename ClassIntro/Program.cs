// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string adi = "Engin";
int yas = 36;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;
Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java";
kurs2.Egitmen = "Kerem Varış";
kurs2.IzlenmeOrani = 64;
Kurs kurs3 = new Kurs();
kurs3.KursAdi = "phyton";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.IzlenmeOrani = 80;

Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


Product product1 = new Product();
product1.Id = 1;
product1.ProductName = "Laptop";
product1.CategoryId = 1;
product1.UnitPrice = 15000;
product1.StockAmount = 10;
Product product2 = new Product();
product2.Id = 2;
product2.ProductName = "mouse";
product2.CategoryId = 2;
product2.UnitPrice = 220;
product2.StockAmount = 20;
Product product3 = new Product();
product3.Id = 3;
product3.ProductName = "Chair";
product3.CategoryId = 2;
product3.UnitPrice = 150;
product3.StockAmount = 100;
Product[] products = new Product[] { product1, product2, product3 };

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ProductName + " " + products[i].UnitPrice + " " + products[i].StockAmount);
}

foreach (var item in products)
{
    Console.WriteLine(item.ProductName + " " + item.UnitPrice + " " + item.StockAmount);
}
int j = 0;
while (j < products.Length)
{
    Console.WriteLine(products[j].ProductName + " " + products[j].UnitPrice + " " + products[j].StockAmount);
    j++;
}


Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var item in kurslar)
{
    Console.WriteLine(item.KursAdi + " " + item.Egitmen + " " + item.IzlenmeOrani);

}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}


class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public int StockAmount { get; set; }
}