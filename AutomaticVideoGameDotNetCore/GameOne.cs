using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class GameOne
    {
        public static void LaunchGameOne()
        {
            Player maxence = new Player(150);

            int countEasyMonster = 0;
            int countHardMonster = 0;

            while (maxence.Alive)
            {
                Monster monster = MonsterCreation.CreateMonster();

                while (monster.Alive && maxence.Alive)
                {
                    maxence.Fight(monster);
                    if (monster.Alive)
                    {
                        monster.Fight(maxence);
                    }
                }

                if (maxence.Alive)
                {
                    if (monster is HardMonster)
                    {
                        countHardMonster++;
                    }
                    else
                    {
                        countEasyMonster++;
                    }
                }
                else
                {
                    Console.WriteLine("Player is dead...");
                    break;
                }
            }
            Console.WriteLine("Good job ! You killed {0} easy monsters and {1} hard monsters !!! You win {2} points :D",
                countEasyMonster, countHardMonster, countEasyMonster + countHardMonster * 2);
        }
    }
}
