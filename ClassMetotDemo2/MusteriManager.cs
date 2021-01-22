using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Ekle(MusteriBilgi musteri)
        {
            Console.WriteLine("müşteri eklendi.tebrikler! :" + musteri.adi);
        }
        public void Sil(MusteriBilgi musteri)
        {
            Console.WriteLine("müşterimiz silinmiştir.iyi bir müşteriydiniz... :" + musteri.adi);
        }
        public void listele(MusteriBilgi musteri)
        {
            Console.WriteLine("müşterilerin bütün bilgisi listelenmiştir :" + musteri.adi + " " + musteri.Id + " " + musteri.yas + " ");
        }
    }
}
