using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            //class SınıfAdı
            //{
                //[Erişim Belirleyici] [Veri Tipi] ÖzellikAdı
                //[Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
                //{
                    //Metot Komutları
                //}
            //}

            //Erişim Belirleyiciler
            // * public
            // * private
            // * internal
            // * protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
