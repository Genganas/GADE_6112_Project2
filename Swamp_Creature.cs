using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Swamp_Creature : Enemy
    {   // Sets the swamp creatures hp to 10 and damage to 1
        public Swamp_Creature(int x, int y) : base(x, y, 10, 10, 1,0)
        {

        }
        // Creates random movement for the swamp creature and then checks for the an empty space to move
        public override Movement ReturnMove(Movement movement = Movement.NoMovement)
        {
            int RandomMove;
            bool drloop = false;

            bool foundEmpty = false;
            for (int i = 0; i < VisionTiles.Length; i++)
            {
                if (VisionTiles[i].Type == Tiletype.EmptyTile)
                {
                    foundEmpty = true;
                    break;
                }
            }
            if (!foundEmpty) return Movement.NoMovement;

            do
            {
                RandomMove = base.random.Next(4);
                if (VisionTiles[RandomMove].Type != Tiletype.EmptyTile)
                {
                    drloop = true;
                }
                else drloop = false;
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
                    return Movement.NoMovement;

            }

        }
    }

}
