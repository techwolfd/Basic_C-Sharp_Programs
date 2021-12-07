using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_21Game
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        
        public void ListPlayers()
        {
            Console.WriteLine("game 1");
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
