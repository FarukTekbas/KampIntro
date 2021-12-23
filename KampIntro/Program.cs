
Console.WriteLine("Hello, World!");
//type safety
//Do not repeat yourself

string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("artış Butonu");
}
else
{
    Console.WriteLine("eşittir butonu");
}


if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);
Console.WriteLine(kategoriEtiketi);
Console.WriteLine(kategoriEtiketi);
Console.WriteLine(kategoriEtiketi);
Console.WriteLine(kategoriEtiketi);
