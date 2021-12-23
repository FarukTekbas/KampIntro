// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string kurs1 = "Yazılım geliştirici yetiştirme Kampı";
string kurs2 = "programlamya bailangıç için temel kurs";
string kurs3 = "java";
string kurs4 = "phyton";
string kurs5 = "C#";

//array 
string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme Kampı", "programlamya bailangıç için temel kurs", "java", "phyton", "C#" };




for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");
foreach (var item in kurslar)
{
    Console.WriteLine(item);
}
Console.WriteLine("foreach bitti");



Console.WriteLine("sayfa sonu");
