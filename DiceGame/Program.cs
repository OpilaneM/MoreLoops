using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //Mõlemad mängijad viskavad täringuid
            // programm kontrollib, kumb mängija viskas rohkem
            //mängija kes viskab rohkem, on võitja
            //*täringuid visatakase 3 korda.
            //programm kuulutab võitjad

            Random rnd = new Random();
          
            

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuRandom}. kasutaja viskas {userRandom}.");


                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            Console.WriteLine($" Lõpptulemus on Arvuti {cpuScore}. Kasutaja {userScore}");
            Console.Read();
        }
    }
}
