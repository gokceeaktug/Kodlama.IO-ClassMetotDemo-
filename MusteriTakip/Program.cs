using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Gökçe";
            musteri1.MusteriSoyadi="Aktuğ";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Büşra";
            musteri2.MusteriSoyadi = "Özen";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Ezgi";
            musteri3.MusteriSoyadi = "Aslan";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAdi = "Büşra";
            musteri4.MusteriSoyadi = "Ayverdi";

            Musteri musteri5 = new Musteri();
            musteri5.MusteriId = 5;
            musteri5.MusteriAdi = "Engin";
            musteri5.MusteriSoyadi = "Demirog";

            Musteri[] musteriListesi = { musteri1,musteri2,musteri3,musteri4,musteri5};

            Console.WriteLine("-------Müşteri Id");
            for (int i = 0; i < 4; i++)

            {
               
                Console.WriteLine(musteriListesi[i].MusteriId);

            }
            Console.WriteLine("-------Müşteri Adları");
            for (int i = 0; i < 4; i++)

            {

                Console.WriteLine(musteriListesi[i].MusteriAdi);

            }
            Console.WriteLine("-------Müşteri Soyadları");
            for (int i = 0; i < 4; i++)

            {

                Console.WriteLine(musteriListesi[i].MusteriSoyadi);

            }

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.add(musteri1);
            musteriManager1.add(musteri2);
            musteriManager1.add(musteri3);
            musteriManager1.add(musteri4);
            musteriManager1.add(musteri5);
            Console.WriteLine("--------------");


            musteriManager1.delete(musteri1);
            musteriManager1.delete(musteri2);
            musteriManager1.delete(musteri3);
            musteriManager1.delete(musteri4);
            musteriManager1.delete(musteri5);


        }
     


    }


   

   


}