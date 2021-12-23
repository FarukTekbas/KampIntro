using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi: {0}", urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi: {0}", urunAdi);
        }
    }
}
