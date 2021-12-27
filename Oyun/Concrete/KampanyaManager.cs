using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    internal class KampanyaManager : IKampanyaService
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " eklendi.");
        }

        public void KampanyaGuncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " güncellendi.");
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " silindi.");
        }
    }
}
