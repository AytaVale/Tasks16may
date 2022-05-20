using System;

namespace homeWork14may
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 10, 20, 41, 52, 68, 72, 74, 76, 88 };
            int customerValue = 0;
            int minValue = 0;
            int maxValue = numbers.Length - 1;
            string request;
            bool isContinue = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Guess a number between given above");
            customerValue = int.Parse(Console.ReadLine());
            do
            {
                int index = (minValue + maxValue) / 2;
                if (numbers[index] == customerValue)
                {
                    Console.WriteLine("The number's index you are thinking of is:"+index);
                    isContinue = false;
                }
                else if (numbers[index]!=customerValue)
                {
                    Console.Write("Is the number's index you are thinking of: "+ numbers[index]+ "?" );
                    Console.WriteLine(" If the number's index you are thinking of is higher - Write H, or lower - write L");
                    request = Console.ReadLine().ToLower();
                    if (request=="h")
                    {
                        minValue = index + 1;
                    }
                    else if (request=="l")

                    {
                        maxValue = index - 1;
                    }
                }
            } while (isContinue);
        }
    }
}
