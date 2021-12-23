using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void GetAll(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine("{0} kişisi ", item.Ad);
            }
        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine("{0} Eklendi", musteri.Ad);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("{0} Yenilendi", musteri.Ad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("{0} Silindi", musteri.Ad);
        }


    }
}
