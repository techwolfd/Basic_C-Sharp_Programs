﻿/*
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
using System.IO;

namespace TO_21Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}. Would you like to join a game of game 21 right now?", PlayerName);

            DateTime dateTime = new DateTime(2021, 12, 10, 8, 32, 45);

            TimeSpan ageGraduation = yearofgraduation - yearofbirth;
            string text = "Here is some text.";
            File.WriteAllText("C:\\Users\\David\\Documents\\GitHub\\Basic_C-_Programs\\Basic_C#_Programs\\TO_21Game_OK\\log.txt ", text);

            string textread = File.ReadAllText("C:\\Users\\David\\Documents\\GitHub\\Basic_C-_Programs\\Basic_C#_Programs\\TO_21Game_OK\\log.txt ");


            //creacion de objetos tipo player y lista de jugadores

            //Game game = new TwentyOneGame();
            //game.Players = new List<string>() { "dav", "bej", "rob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "wolf", "bily", "jorge" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            ////sobre carga de metodos-------------
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();

            //Player player = new Player();
            //player.Name = "wolf";

            //game = game + player;

            //game = game - player;


            //Card cars = new Card();
            //cars.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            //Deck deck = new Deck();
            //deck.Shuffle(5);
            //////deck.Cards = new List<Card>();
            //int n = 1;

            ////Card cardOne = new Card();
            ////cardOne.Face = "queen";
            ////cardOne.Suit = "spades";

            Deck deck = new Deck();

            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //int counter = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(counter);

            //List<Card> newlist = deck.Cards.Where(x => x.Face == Face.Jack).ToList();
            //foreach (Card card in newlist)
            //{
            //    Console.WriteLine(card.Face);
            //}

            List<int> numberlist = new List<int>() { 1, 2, 3, 535, 342, 23 };

            int sum = numberlist.Where(x => x > 20).Sum(); 
            Console.WriteLine(sum);
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
        /// <summary>
        // metodo barajear shuffle
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        /// 
        // se crea el metodo shuffle barajear tipo deck que ingresa un valor tipo deck llamado deck

        

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
