using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            do
            {
                Console.WriteLine("Zehmet olmasa yashinizi qeyd edin:");
                int age = int.Parse(Console.ReadLine());
                if (age>18)
                {
                    Console.WriteLine("Zehmet olmasa balinizi qeyd edin:");
                    int point = int.Parse(Console.ReadLine());
                    if (point>50)
                    {
                        Console.WriteLine("Tebrikler!");
                        isContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("Teesufki baliniz kecid balindan azdir.");
                    }
                }
                else
                {
                    Console.WriteLine("Teesufki yashiniz 18 yashdan ashaqidir.");
                }
                Console.Write("Qeydiyyatdan kecmek isteyen bashqa telebe varmi? (var/xeyr): ");
                string cavab = Console.ReadLine();

                if (cavab == "var")
                {
                    Console.WriteLine("Telebe qeydiyyatina xosh gelmisiniz!");
                }
                else if (cavab == "xeyr")
                {
                    Console.WriteLine("Muracietiniz ucun tesekkurler!");
                    isContinue = false;
                }
                else
                {
                    Console.WriteLine("Melumat eksikliyine gore proqram sona catdi");
                }

            } while (isContinue);
        }
    }
}
