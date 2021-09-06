using System;
using System.Collections.Generic;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        
        public void Taunts()
        {
            Taunt taunt1 = new Taunt();
            taunt1.Phrase = "BOZO!";

            Taunt taunt2 = new Taunt();
            taunt2.Phrase = "YOU SUCK BUTTHEAD!";

            Taunt taunt3 = new Taunt();
            taunt3.Phrase = "BEAT IT, WEIRDO!";

            List<Taunt> taunts = new List<Taunt>() 
            {
                taunt1, taunt2, taunt3
            };
            return taunts;
        }

        public Taunt RandomTaunt()
        {
            Random rand = new Random();
            int randNum = rand.Next(3);
            return Taunts()[randNum];
        }

        
    }
     
}