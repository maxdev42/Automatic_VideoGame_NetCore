using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class FinalBoss
    {
        public int bossLifePoints { get; private set; }
        public bool alive
        {
            get { return bossLifePoints > 0; }
        }
        Dice dice = new Dice();

        public FinalBoss(int points)
        {
            bossLifePoints = points;
        }

        public void Fight(Player player)
        {
            int playerAttackDamages = dice.LaunchDice(25);
            int monsterAttackDamages = dice.LaunchDice(25);

            if (playerAttackDamages <= monsterAttackDamages)
            {
                player.SuffersDamage(dice.LaunchDice(25));
            }
        }

        public void SuffersDamage(int damagePointLife)
        {
            bossLifePoints = bossLifePoints - damagePointLife;
        }

    }
}
