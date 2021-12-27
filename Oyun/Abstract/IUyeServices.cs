using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    internal interface IUyeServices
    {
        void Ekle(Uye uye);
        void Sil(Uye uye);
        void Guncelle(Uye uye);
    }
}
