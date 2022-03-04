using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donusTipi metot_adi(parametrelerListesi/arguman)
            //{
            //komutlar
            //return
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(a, b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        private static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

        class Metotlar
        {
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public int ArttirVeTopla(int deger1, int deger2)
            {
                deger1 += 1;
                deger2 += 1;
                return deger1 + deger2;
            }
        }
    }
}
