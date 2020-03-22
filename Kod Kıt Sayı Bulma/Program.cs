using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Kod_Kıt_Sayı_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList bölüm = new ArrayList();
            Console.Write("Aralığın İlk Sayısını Giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Aralığın Son Sayısını Giriniz:");
            int b = int.Parse(Console.ReadLine());

            for (int j = a; j <= b; j++)
            {
                bölüm.Clear();
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        bölüm.Add(i);
                    }
                }

                int toplam = 0;
                foreach (int s in bölüm)
                {
                    toplam += s;
                }

                if (toplam < j)
                {
                    Console.WriteLine(j);
                }
            }

            Console.ReadKey();
        }
    }
}
