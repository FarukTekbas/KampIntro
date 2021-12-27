using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun.Concrete
{
    internal class SatisManager : ISatisService
    {
        public void Satis(Uye uye, Kampanya kampanya)
        {
            Console.WriteLine(uye.Ad+ " oyuncusuna " + kampanya.KampanyaAdi +" satış yapıldı.");
        }
    }
}
