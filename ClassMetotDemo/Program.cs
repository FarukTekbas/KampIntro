// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Console.WriteLine("Hello, World!");
Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Ad = "Faruk";
musteri1.Soyad = "Tekbas";
musteri1.Bakiye = 1250;
Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Ad = "Kemal";
musteri2.Soyad = "Aslan";
musteri2.Bakiye = 350000;


Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

MusteriManager musteriManager = new MusteriManager();
musteriManager.GetAll(musteriler);
musteriManager.Add(musteri1);
musteriManager.Update(musteri1);
musteriManager.Delete(musteri1);

