using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_21Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public  Deck Deck { get; set; }
        public int Balance { get; set; }

        //public void Deal (List<Card> Hand)
        //{

        //    Hand.Add(Deck.Cards.First());
        //    string card = string.Format(Deck.Cards.First().ToString() + "\n");
        //    Console.WriteLine(card);
        //    using (StreamWriter file = new StreamWriter(@"C:\\Users\\David\\Documents\\GitHub\\Basic_C-_Programs\\Basic_C#_Programs\\TO_21Game_OK\\log.txt", true)) ;
        //    {
        //        file.WriteLine(DateTime.Now);
        //        file.WriteLine(card);
        //    }
            
        //    Deck.Cards.RemoveAt(0);
        //}
    }
}
