using GADE_6112_Project1.GADE_6112_Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GADE_6112_Project1
    {
        internal class Mage : Enemy
        {
            public Mage(int x, int y) : base(x, y, 5, 5, 5,0)
            {
            }
            public override Movement ReturnMove(Movement movement = Movement.NoMovement)
            {
                return Movement.NoMovement;
            }
            public override bool CheckRange(Character target)
            {
                return (Math.Abs(target.X - this.X) <= 1 && Math.Abs(target.Y - this.Y) <= 1);
            }
        }
}
