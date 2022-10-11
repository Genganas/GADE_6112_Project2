using GADE_6112_Project1.GADE_6112_Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    abstract class Enemy : Character
    {
        protected Random random = new Random();

        public Enemy(int x, int y, int hp, int maxHp, int damage) : base(x, y, hp, maxHp, damage)
        {
        }
        public override string ToString() //Output string for enemy
        {
            return "Enemy at [{x},{y}] with damage of ({Damage})";
        }


    }
}
