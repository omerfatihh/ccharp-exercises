using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method2
{
    internal class Program
    {
         static double bakiye = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("--- ATM İŞLEMLERİ ---");
            BakiyeGoster();

            Console.WriteLine("\n--- Para Yatırma ---");
            ParaYatır(500);

            Console.WriteLine("\n--- Para Çekme ---");
            ParaÇek(300);

            Console.WriteLine("\n--- Yetersiz Bakiye Denemesi ---");
            ParaÇek(2000);
        }
       static void BakiyeGoster()
        {
            Console.WriteLine($"Bakiyeniz: {bakiye} TL");
        }
       static void ParaYatır(double miktar)
        {
            bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı.");
            BakiyeGoster();
        }
        static void ParaÇek(double miktar)
        {
            if (miktar > bakiye)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi.");
                BakiyeGoster();
            }
        }
    }
}

