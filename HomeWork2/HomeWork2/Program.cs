using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci reqemi daxil edin:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int secondNum = int.Parse(Console.ReadLine());
            int toplam = 0;
            int ededOrta = 0;
            int ededSay = 0;
            for (int i = firstNum; i < secondNum; i++)
            {
                toplam += i;
                ededSay++;
                ededOrta = toplam / ededSay;
            }
            Console.WriteLine("Iki eded arasinda ededlerin ortalamasi: " + ededOrta);
        }
    }
}
