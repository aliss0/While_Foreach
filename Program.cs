using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while döngüsü
            Console.Write("Bir Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi )
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            Console.WriteLine("------------------------------");
            // a dan z ye kadar tüm harfleri yazdırma 
            char karakter = 'a';
            while(karakter < 'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            Console.WriteLine("");
            Console.WriteLine("----------------Foreach--------------");
            string[] arabalar = { "BMW", "FORD", "TOYOTA", "NİSSAN" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadLine();

        }
       
        
    }
}
