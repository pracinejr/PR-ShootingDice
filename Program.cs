using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            HumanPlayer player2 = new HumanPlayer();
            player2.Name = "Sue";


            OneHigherPlayer player3 = new OneHigherPlayer();
            player3.Name = "Wilma";


            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            
            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Sir Jerk";

            CreativeSmackTalkingPlayer creativeSmackTalker = new CreativeSmackTalkingPlayer();
            creativeSmackTalker.Name = "Captian grumpy";

            SoreLoserPlayer soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Stinky";

            SoreLoserUpperHalfPlayer soreUpperHalfPlayer = new SoreLoserUpperHalfPlayer();
            soreUpperHalfPlayer.Name = "Cheater";

            UpperHalfPlayer upperHalfDude = new UpperHalfPlayer();
            upperHalfDude.Name = "Half Cheater";


            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalker, creativeSmackTalker, soreLoser, soreUpperHalfPlayer, upperHalfDude
            };
            PlayMany(players);

        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}