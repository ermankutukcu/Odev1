using System;

namespace Odev_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 100);  

            
            Console.WriteLine("Rastgele seçilen sayı: " + sayi); //Random sayıyı görmek ve uygulamayı test etmek için aktif hale getirebiliriz

           
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Bir Sayı Giriniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > sayi)
                {
                    Console.WriteLine("Lütfen daha küçük bir sayı giriniz.");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Lütfen daha büyük bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("Tebrikler! "+i+". denemenizde doğru tahmin ettiniz.");
                    Console.ReadLine();
                    break;  // Doğru tahmin yapıldığında döngüden çıkıyoruz
                }
            }
        }
    }
}
