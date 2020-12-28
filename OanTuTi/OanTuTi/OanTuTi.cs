using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OanTuTi
{
    class OanTuTi
    {
        static void Main(string[] args)
        {
            int round = 1;
            int resultP = 0;
            int resultC = 0;
            while (true)
            {
                Console.WriteLine("ROUND: " + round);
                string resultPlayer = playerPlays().ToUpper();
                Console.WriteLine("Result Player: " +resultPlayer);
                Console.WriteLine();
                 string resultComputer = computerPlays().ToUpper();
                Console.WriteLine("Result Computer: " +resultComputer);
                Console.WriteLine();
                if (resultPlayer == resultComputer)
                {
                    Console.WriteLine("ROUND {0}: Player:({1}) - Computer:({2})",round, resultP, resultC);
                    Console.WriteLine();
                }
                else if(resultPlayer.Contains("KEO") && resultComputer.Contains("BAO"))
                {
                    resultP++;
                    Console.WriteLine("ROUND {0}: Player:({1}) - Computer:({2})", round, resultP, resultC);
                    Console.WriteLine();
                }
                else if(resultPlayer.Contains("BUA") && resultComputer.Contains("KEO"))
                {
                    resultP++;
                    Console.WriteLine("ROUND {0}: Player:({1}) - Computer:({2})", round, resultP, resultC);
                    Console.WriteLine();
                }
                else if(resultPlayer.Contains("BAO") && resultComputer.Contains("BUA"))
                {
                    resultP++;
                    Console.WriteLine("ROUND {0}: Player:({1}) - Computer:({2})", round, resultP, resultC);
                    Console.WriteLine();
                }
                else
                {
                    resultC++;
                    Console.WriteLine("ROUND {0}: Player:({1}) - Computer:({2})", round, resultP, resultC);
                    Console.WriteLine();
                }
                round++;               
               if(resultP == 3)
                {
                    Console.WriteLine("Player Win!");                  
                    break;
                }
                else if(resultC == 3) {
                    Console.WriteLine("Computer Win!");
                    break;
                }
               
            }        
        }

        static string computerPlays()
        {
            Console.WriteLine("Computer thinking...");
            string[] computer = new string[3] { "Keo", "Bua", "Bao" };
            Random rd = new Random();
            return computer[rd.Next(3)];
        }

        static string playerPlays()
        {
            Console.WriteLine("Player thinking...");
            string play = Console.ReadLine();
            return play;
        }
    }
}
