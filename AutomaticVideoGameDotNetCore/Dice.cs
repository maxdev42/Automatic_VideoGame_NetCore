using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class Dice
    {

        public static int LaunchDice()
        {
            Random random = new Random();
            int diceResult = random.Next(1, 7);

            return diceResult;
        }

    }
}
