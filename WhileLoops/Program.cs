using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutajal sisestada PIN-koodi
            //Programm võrdleb  sisestatud PIN-loodi  arvuga 1234
            //Kui sisestatud PIN-Kood on midagi muud , konsool kuvab "Vale Pin. Proovi uuesti 
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab tere tulemast!
            // tingimus 1. katsete arv on piiramatu
            //tingimus 2 kasutajal on kolm katset.

           /* int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Hellow world!");
                i = i + 1;
            }

            Console.WriteLine("Kena päeva!");*/


            while (true)

            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale PIN.Proovi uuest.");
                }
                     
            }


               


















        }
    }
}
