using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
     internal class Swamp_Creature : Enemy
    {   // Sets the swamp creatures hp to 10 and damage to 1
        public Swamp_Creature(int x, int y, int hp, int MaxHp, int damage) : base(x, y, hp, MaxHp, damage)
        {
            hp = 10;
            damage = 1;

        }
        // Creates random movement for the swamp creature and then checks for the an empty space to move
        public override Movement ReturnMove(Movement movement = Movement.NoMovement)
        {
            Random RndDirection = new Random();
            int RandomMove = RndDirection.Next(0, 4);
            bool drloop = false;
            do
            {

                if (VisionTiles[RandomMove] != Tile.Tiletype.EmptyTile)
                {
                    drloop = true;
                }
            } while (drloop);
            switch (RandomMove) // Switch used to determine the direction 
            {
                case 0:
                    return Movement.Up;
                case 1:
                    return Movement.Down;
                case 2:
                    return Movement.Left;
                case 3:
                    return Movement.Right;
                default:
                    return Movement.noMovement;

            }

        }
    }

}


