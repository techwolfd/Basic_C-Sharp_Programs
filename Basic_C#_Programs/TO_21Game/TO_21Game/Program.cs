using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck.Cards = new List<Card>();


            //Card cardOne = new Card();
            //cardOne.Face = "queen";
            //cardOne.Suit = "spades";


            Console.WriteLine (deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.ReadLine();

        }
    }
}
