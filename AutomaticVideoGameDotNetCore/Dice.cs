using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class Dice
    {

        public int LaunchDice()
        {
            Random random = new Random();
            int diceResult = random.Next(1, 7);

            return diceResult;
        }

        public int LaunchDice(int value)
        {
            Random random = new Random();
            int diceResult = random.Next(1, value);

            return diceResult;
        }

    }
}
