using System;
using System.Collections.Generic;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public SmackTalkingPlayer()
        {
            Taunt = "YOU SUCK AT THIS!";
        }

        public override int Roll()
        {
            Console.WriteLine($"{Taunt}");
            return new Random().Next(DiceSize) + 1;
        }

    }
        
}