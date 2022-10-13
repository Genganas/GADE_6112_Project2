using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
	internal class Mage : Enemy
	{
		public Mage(int x, int y) : base(x, y, 5, 5, 5)
		{

		}
		public override Movement ReturnMove(Movement movement = Movement.NoMovement)
		{
			return move == Movement.NoMovement;
		}
		public override CheckRange()
        {
			bool foundEmpty = false;
			for (int i = 0; i < VisionTiles.Length; i++)
			{
				if (VisionTiles[i].Type == Tiletype.EmptyTile)
				{
					foundEmpty = true;
					break;
				}
				if (!foundEmpty) ;
                {

                }
			}
	}
}