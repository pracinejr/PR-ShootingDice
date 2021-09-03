using System;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        
        List<Taunt> taunts = new List<Taunt>() 
        {

        }

        public virtual void Play(Player smackTalkPlayer)
        {
            smackTalkPlayer.Roll().Taunt(); 
        }
    }
     
}