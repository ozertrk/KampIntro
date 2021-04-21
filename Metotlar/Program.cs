using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Urun urun1 = new Urun();

            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 151;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.Fiyati = 1512;

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------------");

            }

            Console.WriteLine("-----------------METOTLAR-------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}
