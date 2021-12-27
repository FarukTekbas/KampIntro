using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // Interface leri birbirinin alternatifi olan fakat kod içerikleri farklı olanlar için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
