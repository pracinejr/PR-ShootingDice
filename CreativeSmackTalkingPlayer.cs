using System;
using System.Collections.Generic;


namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; set; }

        List<string> Taunt = new List<string>()
        {
            "GET BETTER FOO!",
            "DON'T BE A TURD, TURD!",
            "WOW, YOU MAKE THIS LOOK HARD!"
        };
      
      
        public void RandomTaunt() 
        {
            int r = new Random().Next(Taunt.Count);
            string taunt = Taunt[r];
            Console.WriteLine($"{taunt}");
        }

          public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            RandomTaunt();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }
        
         
        
    }
}