using System;

namespace AutomaticVideoGameDotNetCore
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            LaunchGame();

            Console.ReadLine();
        }

        private static void LaunchGame()
        {
            Player maxence = new Player(150);

            int countEasyMonster = 0;
            int countHardMonster = 0;

            while (maxence.Alive)
            {
                Monster monster = CreateMonster();

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

        private static Monster CreateMonster()
        {
            if (random.Next(2) == 0)
                return new Monster();
            else
                return new HardMonster();
        }
    }
}
