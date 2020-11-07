using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class Monster
    {
        public bool Alive { get; private set; }
        private const int damages = 10;

        public Monster()
        {
            Alive = true;
        }

        public virtual void Fight(Player player)
        {
            int playerAttackDamages = LaunchDice();
            int monsterAttackDamages = LaunchDice();

            if (playerAttackDamages <= monsterAttackDamages)
            {
                player.SuffersDamage(damages);
            }
        }

        public void SuffersDamage()
        {
            Alive = false;
        }

        public int LaunchDice()
        {
            return Dice.LaunchDice();
        }

    }
}
