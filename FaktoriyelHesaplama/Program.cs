using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {


            int x;
            int t = 1;

            Console.WriteLine(new string('-',57));
            Console.WriteLine("Faktöriyel Hesaplayıcıya Hoşgeldiniz! | developed by Mors");
            Console.WriteLine(new string('-', 57));

            System.Threading.Thread.Sleep(1500);

            Console.Write("Faktöriyeli Hesaplanacak Olan Sayıyı Girin: ");
            x = Convert.ToInt32(Console.ReadLine());


            while (x > 1)
            {
                t = t * x;
                x--;
            }
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Hesaplanıyor...");
            System.Threading.Thread.Sleep(1500);
            Console.Write("Sonuç:" + t);

            Console.Read();

        }
    }
}
