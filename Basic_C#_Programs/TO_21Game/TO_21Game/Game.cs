using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_21Game
{
    public abstract class Game
    {

        //public List<string> Players { get; set; }
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {

            //foreach (string player in Players)
            foreach (Player player in Players)
            {
                //Console.WriteLine(player);
                Console.WriteLine(player);
            }


        }
         public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
    }
}
