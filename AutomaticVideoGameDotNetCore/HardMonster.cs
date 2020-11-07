using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class HardMonster : Monster
    {
        public const int spellMonster = 5;

        public override void Fight(Player player)
        {
            base.Fight(player);
            player.SuffersDamage(SpellAttack());
        }

        private int SpellAttack()
        {
            int diceResult = Dice.LaunchDice();

            if (diceResult == 6)
            {
                return 0;
            }
            return spellMonster * diceResult;
        }
    }
}
