using Encapsulation;
using System;

class Program
{
    static void Main()
    {
        // Araba nesnesi oluşturma
        Araba araba = new Araba();

        // Kullanıcıdan bilgi alma
        Console.Write("Marka girin: ");
        araba.Marka = Console.ReadLine();

        Console.Write("Model girin: ");
        araba.Model = Console.ReadLine();

        Console.Write("Renk girin: ");
        araba.Renk = Console.ReadLine();

        // Kapı sayısını kullanıcıdan alma ve atama
        Console.Write("Kapı sayısını girin (2 veya 4): ");
        if (int.TryParse(Console.ReadLine(), out int kapıSayısı))
        {
            araba.KapıSayısı = kapıSayısı; // Kullanıcıdan alınan değeri ata
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz.");
            araba.KapıSayısı = -1; // Geçersiz giriş durumunda kapı sayısını -1 olarak ayarla
        }

        // Bilgileri ekrana yazdırma
        araba.BilgileriYazdir();
    }
}
