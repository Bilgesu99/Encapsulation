using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int _kapıSayısı; // private yapıyoruz

        // Kapı sayısını kapsüllü (encapsulated) olarak tanımlıyoruz
        public int KapıSayısı
        {
            get
            {
                return _kapıSayısı; // `get` accessor - Bu, `KapıSayısı` property'sinin mevcut değerini döndürür.
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _kapıSayısı = value; // `set` accessor - Bu, `KapıSayısı` property'sine geçerli bir değer atar.
                }
                else
                {
                    Console.WriteLine("Hata: Kapı sayısı sadece 2 veya 4 olabilir."); // Geçersiz değer girildiğinde hata mesajı
                    _kapıSayısı = -1; // Geçersiz değer girildiğinde kapı sayısını -1 olarak ayarla
                }
            }
        }
        // Araba bilgilerini ekrana yazdırma metodu
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Renk: {Renk}");
            Console.WriteLine($"Kapı Sayısı: {KapıSayısı}");
        }
    }


}











