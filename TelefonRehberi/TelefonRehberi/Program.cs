using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon();
            string islem = " ";
            bool cikis = false;
            do
            {
                AnaEkranGoster();
                islem = Console.ReadLine();
                cikis = Islemler(telefon, islem);

            }while (!cikis);
        }

        static void AnaEkranGoster()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Varolan Nummaryı Sil");
            Console.WriteLine("(3) Varolan Numarayı Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama yap");
            Console.WriteLine("(0) Çıkış");
        }
        static bool Islemler(Telefon telefon, string islem)
        {
            bool cikis = false;
            if (islem == "0")
            {
                cikis = true;
            }
            else if (islem == "1")
            {
                Console.Write("Lütfen isim giriniz: ");
                string isim = Console.ReadLine();
                Console.Write("Lütfen soyisim giriniz: ");
                string soyisim = Console.ReadLine();
                Console.Write("Lütfen telefon numarası giriniz: ");
                string telefonNo = Console.ReadLine();
                telefon.NumaraKaydet(isim, soyisim, telefonNo);
            }
            else if (islem == "2")
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string ad = Console.ReadLine();
                telefon.NumaraSil(ad);
            }
            else if(islem == "3")
            {
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string ad = Console.ReadLine();
                telefon.NumarayıGuncelle(ad);
            }
            else if (islem == "4")
            {
                telefon.RehberiListele();
            }
            else if(islem == "5")
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");

                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                string secim = Console.ReadLine();
                Console.Write("ARA: ");
                string ara = Console.ReadLine();
                telefon.RehberdeAramaYap(ara, secim);
            }
            else
            {
                Console.WriteLine("Geçerli İşlem Seçiniz.");
            }
            return cikis;
        }
    }

    class Telefon
    {
        public List<Kisi> Kisiler { get; set; } = new List<Kisi>();

        public Telefon()
        {
            Kisiler.Add(new Kisi
            {
                Ad = "Emre",
                Soyad = "Seylim",
                TelefonNo = "05345678913"
            });
            Kisiler.Add(new Kisi
            {
                Ad = "Kaan",
                Soyad = "Yılmaz",
                TelefonNo = "05389209538"
            });
            Kisiler.Add(new Kisi
            {
                Ad = "Gökçe",
                Soyad = "Nur",
                TelefonNo = "05389204329"
            });
            Kisiler.Add(new Kisi
            {
                Ad = "Ayşe",
                Soyad = "Çakır",
                TelefonNo = "05389202984"
            });
            Kisiler.Add(new Kisi
            {
                Ad = "Osman",
                Soyad = "Çelik",
                TelefonNo = "05389204523"
            });
        }

        public void NumaraKaydet(string ad, string soyad, string numara)
        {
            Kisi kisi = new Kisi(ad, soyad, numara);
            Kisiler.Add(kisi);
            Console.WriteLine("Numara Başarıyla Kaydedildi.");
        }

        public void NumaraSil(string ad)
        {
            bool bulundu = false;
            string devam = " ";
            ad.ToLower();
            do
            {
                bulundu = false;
                foreach (Kisi kisi in Kisiler)
                {
                    if(kisi.Ad.ToLower() == ad || kisi.Soyad.ToLower() == ad)
                    {
                        Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n)", ad);
                        string sil = Console.ReadLine();
                        sil.ToLower();
                        if(sil == "y")
                        {
                            Kisiler.Remove(kisi);
                            Console.WriteLine("Kişi Başarıyla Silindi");
                        }
                        bulundu = true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için  : (1)");
                    Console.WriteLine("* Yeniden denemek için       : (2)");
                    devam = Console.ReadLine();
                }
            } while (devam == "2");
        }

        public void NumarayıGuncelle(string ad)
        {
            bool bulundu = false;
            string devam = " ";
            do
            {
                bulundu = false;
                foreach(Kisi kisi in Kisiler)
                {
                    if (kisi.Ad == ad || kisi.Soyad == ad)
                    {
                        Console.WriteLine("Kişi Bulundu");
                        Console.WriteLine("Güncel Ad: ");
                        kisi.Ad = Console.ReadLine();
                        Console.WriteLine("Güncel Soyad: ");
                        kisi.Soyad = Console.ReadLine();
                        Console.WriteLine("Güncel Numara: ");
                        kisi.TelefonNo = Console.ReadLine();
                        Console.WriteLine("Kişi Başarıyla Güncellendi.");
                        bulundu = true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için  : (1)");
                    Console.WriteLine("* Yeniden denemek için       : (2)");
                    devam = Console.ReadLine();
                }
            } while (devam == "2");
        }

        public void RehberiListele()
        {
            Console.WriteLine("TELEFON REHBERİ");
            Console.WriteLine("***************************************");
            foreach(Kisi kisi in Kisiler)
            {
                Console.WriteLine("İsim: {0}", kisi.Ad);
                Console.WriteLine("Soyisim: {0}", kisi.Soyad);
                Console.WriteLine("Telefon Numarası: {0}", kisi.TelefonNo);
                Console.WriteLine("-----------------------------------");
            }
        }

        public void RehberdeAramaYap(string ara, string islem)
        {
            ara.ToLower();
            Console.WriteLine("Arama Sonuçlarınız: ");
            Console.WriteLine("**********************************************");
            if (islem == "1")
            {
                foreach(Kisi kisi in Kisiler)
                {
                    if(kisi.Ad.ToLower() == ara || kisi.Soyad.ToLower() == ara)
                    {
                        Console.WriteLine("İsim: {0}", kisi.Ad);
                        Console.WriteLine("Soyisim: {0}", kisi.Soyad);
                        Console.WriteLine("Telefon Numarası: {0}", kisi.TelefonNo);
                        Console.WriteLine("---------------------------------------");
                    }
                }
            }
            else if (islem == "2")
            {
                foreach (Kisi kisi in Kisiler)
                {
                    if (kisi.TelefonNo == ara)
                    {
                        Console.WriteLine("İsim: {0}", kisi.Ad);
                        Console.WriteLine("Soyisim: {0}", kisi.Soyad);
                        Console.WriteLine("Telefon Numarası: {0}", kisi.TelefonNo);
                        Console.WriteLine("---------------------------------------");
                    }
                }
            }
        }
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNo { get; set; }

        public Kisi(string ad, string soyad, string numara)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.TelefonNo = numara;
        }

        public Kisi()
        {

        }
    }
}
