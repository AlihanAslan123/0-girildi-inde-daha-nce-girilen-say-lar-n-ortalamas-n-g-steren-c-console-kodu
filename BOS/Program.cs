using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOS
{
    class Program
    {
        static void Main(string[] args)
        {
             int sayi;
             int sayac = 0;
             double toplam = 0;
             double ort = 0;
             while (true)
             {
                 Console.Write("sayı giriniz: ");
                 sayi = int.Parse(Console.ReadLine());
                 toplam += sayi;
                 sayac++;
                 if (sayi == 0)
                 {
                     goto a;
                 }

             }

             a:
             ort = toplam / sayac;
             Console.WriteLine("Girilen sayıların ortalaması = "+ort);
             Console.ReadLine(); 

        }
    }
}
