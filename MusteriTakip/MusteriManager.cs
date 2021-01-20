using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void add(Musteri musteri)
        {
            Console.WriteLine("Eklenen Kişi : " + musteri.MusteriAdi + musteri.MusteriSoyadi);
        }

        public void delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + " silindi.");
        }

        
       
    }
}
