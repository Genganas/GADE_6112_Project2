using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    internal class Hero : Character
    {


        public Hero(int x, int y, int hp, int maxHp, int damage) : base(x, y, hp, maxHp, damage)
        {
            damage = 2;
        }

        // Recieves the players movement from move and then creates then checks if a move can be made
        public override Movement ReturnMove(Movement move = Movement.noMovement)
        {
            if (move == Movement.noMovement)
                return Movement.noMovement;
            if (VisionTiles[(int)move] != Tiletype.EmptyTile)
                return Movement.noMovement;
            else
                return move;
        }

        public override string ToString() // String that displays the hero's stats
        {
            return "Player Stats: \nHP: {hp}/{maxHp} \nDamage: {damage} \n[{x},{y}]";
        }

        public static explicit operator Hero(void v)
        {
            throw new NotImplementedException();
        }
    }
}
