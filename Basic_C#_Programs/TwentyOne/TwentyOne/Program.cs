
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name.");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("and how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", PlayerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "Yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(PlayerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivePlaying = true;
                while (player.IsActivePlaying && player.Balance > 0)
                {
                    game.Play();
                }
            }

                   
            //Deck deck = new Deck();

            //deck.Shuffle(3);

            

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            
            //Console.ReadLine();

        }
        

        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }

}
