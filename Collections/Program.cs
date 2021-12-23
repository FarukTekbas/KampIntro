// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] names = new string[] { "Engin", "Murat", "Halil", "Kerem" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);
//names[4] = "İlker";
//Console.WriteLine(names[4]);

List<string> isimler = new List<string> { "Engin", "Murat", "Halil", "Kerem" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);
isimler.Add("İlker");
Console.WriteLine(isimler[4]);