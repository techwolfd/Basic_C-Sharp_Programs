using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_21Game
{
    public class Deck
    {
        public Deck()
        {
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            Cards = new List<Card>();

            for(int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }

            }
            //List<string> Suits = new List<string> { "Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>
            //{
            //    "Two","three","Four","Five","Six","Seven"
            //    ,"Eight","Nine","Ten","Jack","Queen","King","Ace"
            //};
            
            //foreach (string face in Faces)
            //{
            //    //foreach (string suit in Suits)
            //    //{
            //    //    Card card = new Card();
            //    //    card.Face = face;
            //    //    card.Suit = suit;
            //    //    Cards.Add(card);
            //    //}
            //}
        }
        

        public List<Card> Cards { get; set; }

        public void Shuffle(/*Deck deck,/* out int timesShuffled,*/ int times = 1)
        {
            //timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                //timesShuffled++;
                List<Card> Templist = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    Templist.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //la lista temporal la pasa a las acartas de deck
                this.Cards = Templist;
                //retorna deck
            }

            

        }
    }
}
