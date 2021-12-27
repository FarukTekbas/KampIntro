using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    internal class UyeManager : IUyeServices
    {
        public void Ekle(Uye uye)
        {
            Console.WriteLine("{0} eklendi.", uye.Ad);
        }

        public void Guncelle(Uye uye)
        {
            Console.WriteLine("{0} guncellendi.", uye.Ad);
        }

        public void Sil(Uye uye)
        {
            Console.WriteLine("{0} silindi.", uye.Ad);
        }
    }
}
