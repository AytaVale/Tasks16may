using System;

namespace TekEdedTopla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci reqemi daxil edin:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int value2 = int.Parse(Console.ReadLine());
            int sum = 0;
            while (value1 < value2)
            {
                if (value1%2!=0)
                {
                    sum += value1;
                }
                value1++;
            }
            Console.WriteLine("Iki eded arasindaki tek ededlerin cemi:" + sum);
        }
    }
}
