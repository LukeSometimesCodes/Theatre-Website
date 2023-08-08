using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes_and_Objects_Game
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Casino what is name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello {0} join 21 game", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer =="ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("leave");
            }
            Console.ReadLine();
        }
       
       
    }
}
