using System;

namespace Guessinggamethreetries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta number");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userGuess)
                {
                    Console.WriteLine("Tubli, õige number");
                    break;
                }
                else
                {
                    i++; //i = i + i
                    Console.WriteLine($"Proovi Uuesti {3 - 1} katset on jäänud ");

                }
            }

            if(i == 3)
                {
                Console.WriteLine("oled mängu kaotanud");
                }
        }        
    }
}
