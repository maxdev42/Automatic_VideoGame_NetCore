using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticVideoGameDotNetCore
{
    public class Player
    {
        private int playerLifePoints;
        private bool alive;
        private int points;

        public int PlayerLifePoints
        {
            get { return playerLifePoints; }
            set { playerLifePoints = value; }
        }

        public bool Alive
        {
            get { return PlayerLifePoints > 0; }
            set { alive = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player(int lifePoints)
        {
            PlayerLifePoints = lifePoints;
            Alive = true;
            Points = 0;
        }

        public void Fight(Monster monster)
        {
            int playerAttackDamages = LaunchDice();
            int monsterAttackDamages = LaunchDice();

            if (playerAttackDamages >= monsterAttackDamages)
            {
                monster.SuffersDamage();
            }
        }

        public void SuffersDamage(int damagePointLife)
        {
            PlayerLifePoints = PlayerLifePoints - damagePointLife;
        }

        public int LaunchDice()
        {
            return Dice.LaunchDice();
        }

        public bool ShieldProtect()
        {
            return LaunchDice() <= 2;
        }

    }
}
