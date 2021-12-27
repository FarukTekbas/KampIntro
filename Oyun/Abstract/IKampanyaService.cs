using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    internal interface IKampanyaService
    {
        public void KampanyaEkle(Kampanya kampanya);
        public void KampanyaSil(Kampanya kampanya);
        public void KampanyaGuncelle(Kampanya kampanya);

    }
}
