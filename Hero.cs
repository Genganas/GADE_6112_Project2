using GADE_6112_Project1.GADE_6112_Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Hero : Character
    {
       

       public Hero(int x, int y, int hp, int maxHp,int amount) : base(x, y, hp, maxHp, 2,0)
        {

        }

        // Recieves the players movement from move and then creates then checks if a move can be made
        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            return (move == Movement.NoMovement || VisionTiles[(int)move].Type != Tiletype.EmptyTile) ? Movement.NoMovement : move;
        }

        public override string ToString() // String that displays the hero's stats
        {
            return $"Player Stats: \nHP: {hp}/{maxhp} \nDamage: {damage} \nGold: {amount} \n[{x},{y}]";
        }

      
    }
}