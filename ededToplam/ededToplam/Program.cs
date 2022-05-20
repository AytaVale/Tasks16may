using System;

namespace ededToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci reqemi daxil edin:");
            int birinciReqem = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int ikinciReqem = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = birinciReqem; i < ikinciReqem; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Iki eded arasi ededlerin toplami:" + sum);
        }
    }
}
