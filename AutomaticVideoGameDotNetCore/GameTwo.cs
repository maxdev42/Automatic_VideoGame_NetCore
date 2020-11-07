using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    class GameTwo
    {
        public static void LaunchGameTwo()
        {
            Player maxence = new Player(150);
            FinalBoss finalBoss = new FinalBoss(250);
            while (maxence.Alive && finalBoss.alive)
            {
                maxence.Fight(finalBoss);
                if (finalBoss.alive)
                    finalBoss.Fight(maxence);
            }
            if (maxence.Alive)
                Console.WriteLine("Amazing, you saved the princess !");
            else
                Console.WriteLine("Game over...");
        }
    }
}
