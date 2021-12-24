// See https://aka.ms/new-console-template for more information
using MyDictionary;

Console.WriteLine("Hello, World!");


GenericDictionary<int, string> myDictionary = new GenericDictionary<int, string>();

myDictionary.Add(1, "Faruk");
myDictionary.Add(2, "Ahsen");

Console.WriteLine("Total Length: " + myDictionary.Length);

foreach (var value in myDictionary.Values)
{
    Console.WriteLine("Value: " + value);
}







