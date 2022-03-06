using System;
using System.Collections;

namespace Odev2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 20;
            bool asal = false;
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlamayanSayilar = new ArrayList();
            while (sayac != 0)
            {
                asal = true;
                Console.Write("Bir sayı giriniz: ");
                bool success = int.TryParse(Console.ReadLine(), out int sayi);
                if (success)
                {
                    if (sayi == 2)
                    {
                        asalSayilar.Add(sayi);
                        asal = false;
                    }
                    else if(sayi == 1 || sayi == 0)
                    {
                        asalOlamayanSayilar.Add(sayi);
                        asal = false;
                    }

                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi%i == 0)
                        {
                            asalOlamayanSayilar.Add(sayi);
                            asal = false;
                            break;
                        }
                    }

                    if (asal)
                    {
                        asalSayilar.Add(sayi);
                    }
                    sayac--;
                }
            }

            asalSayilar.Sort();
            asalOlamayanSayilar.Sort();
            asalSayilar.Reverse();
            asalOlamayanSayilar.Reverse();
            Console.WriteLine("Asal Sayılar: ");
            foreach (int i in asalSayilar)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Asal Olmayan Sayılar: ");
            foreach (int i in asalOlamayanSayilar)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            float asalOrtalama = 0, asalOlmayanOrtalama = 0;
            int asalToplam = 0, asalOlmayanToplam = 0;
            foreach (int i in asalSayilar)
            {
                asalToplam += i;
            }

            foreach(int i in asalOlamayanSayilar)
            {
                asalOlmayanToplam += i; 
            }

            asalOrtalama = (float)asalToplam / (float)asalSayilar.Count;
            asalOlmayanOrtalama = (float)asalOlmayanToplam / (float)asalOlamayanSayilar.Count;

            Console.WriteLine("Asal Sayıların Adedi: {0},  Asal Sayıların Ortalaması: {1}",asalSayilar.Count, asalOrtalama);
            Console.WriteLine("Asal Olmayan Sayıların Adedi: {0},  Asal Olmayan Sayıların Ortalaması: {1}", asalOlamayanSayilar.Count, asalOlmayanOrtalama);
        }
    }
}
