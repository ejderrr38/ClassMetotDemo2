using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriBilgi musteri1 = new MusteriBilgi();

            musteri1.Id = 123456789;
            musteri1.adi = "Tefo ";
            musteri1.yas = 38;

            MusteriBilgi musteri2 = new MusteriBilgi();

            musteri2.Id = 452789789;
            musteri2.adi = "yakışıklı serdar";
            musteri2.yas = 54;

            MusteriBilgi musteri3 = new MusteriBilgi();

            musteri3.Id = 987654321;
            musteri3.adi = "kamil";
            musteri3.yas = 48;

            MusteriBilgi musteri4 = new MusteriBilgi();

            musteri4.Id = 654321987;
            musteri4.adi = "şebnem";
            musteri4.yas = 29;


            MusteriBilgi[] musteriler = new MusteriBilgi[] { musteri1, musteri2, musteri3 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.adi + " : " + Musteri.yas);
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            Console.WriteLine("............");
            musteriManager.Sil(musteri2);
            Console.WriteLine("..........");
            musteriManager.listele(musteri1);
            Console.WriteLine("işlemleriniz bitmiştir.");
        }
    }
}
