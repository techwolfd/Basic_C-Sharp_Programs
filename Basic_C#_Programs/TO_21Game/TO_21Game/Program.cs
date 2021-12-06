/*
Este programa muestra el juego de 21
Autor: David Cortes
Fecha de creacion: 2 de diciembre de 2021
Feha de ultima modificacion: 6 de diciembre de 2021
 */
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
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled,3);
            //deck.Cards = new List<Card>();


            //Card cardOne = new Card();
            //cardOne.Face = "queen";
            //cardOne.Suit = "spades";

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("times shuffled{0}", timesShuffled);
            Console.ReadLine();

        }
        /// <summary>
        // metodo barajear shuffle
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        /// 
        // se crea el metodo shuffle barajear tipo deck que ingresa un valor tipo deck llamado deck

        public static Deck Shuffle (Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> Templist = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    Templist.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                //la lista temporal la pasa a las acartas de deck
                deck.Cards = Templist;
                //retorna deck
            }
            
            return deck;

        }

        //public static Deck Shuffle (Deck deck, int times)
        //{
        //    for (int i=0; i < times;i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
