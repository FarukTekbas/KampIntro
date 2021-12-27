// See https://aka.ms/new-console-template for more information


using Oyun;
using Oyun.Concrete;
using Oyun.Entities;

Uye uye1 = new Uye();
uye1.Id = 1;
uye1.Ad = "Faruk";
uye1.Soyad = "Tekbas";
uye1.TcNo = "12345678910";
uye1.DogumYili = 1994;

Uye uye2 = new Uye();
uye2.Id = 2;
uye2.Ad = "Ahsen";
uye2.Soyad = "Tekbas";
uye2.TcNo = "12345678910";
uye2.DogumYili = 1993;

UyeManager uyeManager = new UyeManager();
uyeManager.Ekle(uye1);
uyeManager.Guncelle(uye1);
uyeManager.Sil(uye1);

Kampanya kampanya1 = new Kampanya();
kampanya1.Id = 1;
kampanya1.KampanyaAdi = "Yaz Kampanyası";

Kampanya kampanya2 = new Kampanya();
kampanya2.Id = 2;
kampanya2.KampanyaAdi = "Kış Kampanyası";

KampanyaManager kampanyaManager = new KampanyaManager();
kampanyaManager.KampanyaEkle(kampanya2);
kampanyaManager.KampanyaGuncelle(kampanya2);
kampanyaManager.KampanyaSil(kampanya2);


SatisManager satisManager = new SatisManager();
satisManager.Satis(uye2, kampanya1);

