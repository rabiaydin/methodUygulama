using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToCharArray kullanımı
            Console.WriteLine("Bir kelime giriniz..");
            string kelime = Console.ReadLine();
            char[] harfler = kelime.ToCharArray();
            //har[] harfİlk = kelime.ToCharArray(3, 1);

            //Console.WriteLine($"yazdığınız kelimenin ilk harfi: {harfİlk}");
            Console.WriteLine($"{kelime} kelimesinde  yer alan harfler:");
            foreach (char harf in harfler)
                Console.WriteLine(harf);


            //Contains kullanımı
            //Amaç tekerleme içerisinde aranan kelimenin var olup olmadığını bulmak

            Console.WriteLine("----------------------------------------");
            string tekerleme = "Sen seni bil sen seni, bil sen seni, bil sen seni, sen seni bilmezsen patlatırlar enseni";
            Console.WriteLine($"Tekerleme : {tekerleme}");
            string kelime1 = "bil";
           
            bool varMı = tekerleme.Contains(kelime1);
            
            if (varMı)
            {
                Console.WriteLine($"Tekerlemenin içinde {kelime1} kelimesi vardır.");
            }
            else
            {
                Console.WriteLine("tekerlemede aranan kelime yoktur.");
            }

            //Startwith kullanımı
            //mini bir oyun kelimeyi görmek için hangi harfle başladığının bilinmesi gerekiyor.
            Console.WriteLine("----------------------------------------");
            string oyunKelimesi = "matematik";
            Console.WriteLine("kelimeyi görmek için ilk harfini tahmin ediniz. Tahmininiz:");
            string tahmin = Console.ReadLine();
            bool bulduMu = false;
            while (!bulduMu)
            {
                if (oyunKelimesi.StartsWith(tahmin))
                {
                    Console.WriteLine("Tebrikler ilk harfi doğru tahmin ettiniz. Kelime:{0}",oyunKelimesi);
                    bulduMu = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Tahmininiz doğru değil.Lütfen tekrar tahmin ediniz.");
                    tahmin = Console.ReadLine();
                }
            }
            //Split kullanımı
            //Girilen cümleyi kelimelere bölmek amaçlanıyor.
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Kelimelerine ayırmak için cümle giriniz.");
            string cumle = Console.ReadLine();
            string[] cumleparcalari = cumle.Split(' ');
            Console.WriteLine("Cumlede yer alan kelimeler:");
            for (int i=0;i<cumleparcalari.Length;i++)
            {
                Console.WriteLine($"{i+1}. kelime:{cumleparcalari[i]}");
            }
            //Char methodları
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("bir metin giriniz.");
            string metin = Console.ReadLine();
            char[] metin1 = metin.ToCharArray();
            bool sayiMi = false;
            bool rakamMi = false;
            foreach (char mtn in metin1)
            {
                if (char.IsNumber(mtn))
                {
                    Console.WriteLine("Girilen metinde rakam bulunmaktadır.");
                    sayiMi = true;
                    break;
                }
            }
            if (!sayiMi)
            {
                Console.WriteLine("Girilen metinde rakam bulunmamaktadır.");
            }
            foreach (char mtn in metin1)
            {
                if (char.IsSymbol(mtn))
                {
                    Console.WriteLine("Girilen metinde sembol ifadeleri bulunmaktadır.");
                    rakamMi = true;
                    break;
                }
            }
            if (rakamMi)
            {
                Console.WriteLine("girilen metinde sembool ifadeleri bulunmamaktadır.");

            }


            Console.ReadLine();
        }
    }
}
