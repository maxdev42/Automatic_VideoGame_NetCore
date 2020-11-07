using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class MonsterCreation
    {
        private static Random random = new Random();

        public static Monster CreateMonster()
        {
            if (random.Next(2) == 0)
                return new Monster();
            else
                return new HardMonster();
        }
    }
}
