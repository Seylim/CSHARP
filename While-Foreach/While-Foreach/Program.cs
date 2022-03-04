﻿using System;

namespace While_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsol a yazdıran program
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar tüm harfleri konsol a yazdır
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("***** Foreach *****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
