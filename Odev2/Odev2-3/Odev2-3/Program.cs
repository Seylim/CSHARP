using System;
using System.Collections.Generic;

namespace Odev2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = CumleAl();
            string[] kelimeler = KelimeleriBul(cumle.ToLower());
            List<string> sesliHarfler = SesliHarfBul(kelimeler);

            foreach (string s in sesliHarfler)
            {
                Console.Write(s + " ");
            }
        }

        static string CumleAl()
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            return cumle;
        }

        static string[] KelimeleriBul(string cumle)
        {
            string[] kelimeler = cumle.Split(' ');
            return kelimeler;
        }

        static List<string> SesliHarfBul(string[] kelimeler)
        {
            string[] sesliHarfler = { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
            List<string> sesliHarf= new List<string>();
            foreach(string kelime in kelimeler)
            {
                for(int i = 0; i < kelime.Length; i++)
                {
                    if(kelime[i] == 'a' || kelime[i] == 'e' || kelime[i] == 'ı' || kelime[i] == 'i' || 
                       kelime[i] == 'o' || kelime[i] == 'ö' || kelime[i] == 'u' || kelime[i] == 'ü')
                    {
                        sesliHarf.Add(kelime[i].ToString());
                    }
                }
            }
            return sesliHarf;
        }
    }
}
