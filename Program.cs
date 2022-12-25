using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantıksalOperatorlerOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("1. sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a<b && a>c) || (a>b && a<c))
            {
                Console.WriteLine("{0} sayısı ortancadır",a);
            }
            else if (b<a && b>c || b>a && b<c)
            {
                Console.WriteLine("{0} sayısı ortancadır",b);
            }
            else if (c<a && c>b || c>a && c<b)
            {
                Console.WriteLine("{0} sayısı ortancadır",c);
            }
            else
            {
                Console.WriteLine("sayılar arasında eşitlik söz konusu. ortanca bulunamadı");
            }
            Console.ReadKey();
        }
    }
}
