using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    abstract class Character : Tile
    {

        protected int hp; // Health points 
        protected int maxhp; // Max Health
        protected int damage; // Attack damage
        protected Tiletype[] visionTiles = new Tiletype[4]; // Vision array

        public enum Movement  // Movement Enum for character
        {
            noMovement,
            Up,
            Down,
            Left,
            Right,
            NoMovement
        }
        public Character(int x, int y, int hp, int maxHp, int damage) : base(x, y) //Accessor
        {
            this.hp = hp;
            this.maxhp = maxHp;
            this.damage = damage;
        }

        public Tiletype[] VisionTiles { get => VisionTiles; set => VisionTiles = value; }


        public virtual void Attack(Character target) //Attack method to decrease Hp
        {
            if (DistanceTo(target) < 1) return;

            target.hp -= this.damage;
        }

        public bool isDead() // Checks if a character is dead 
        {
            return (hp <= 0);

        }
        public virtual bool CheckRange(Character target) // Checks fot the range 
        {
            if (DistanceTo(target) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)// Checks for the distance of the enemy from a character
        {
            return Math.Abs(this.X - target.X) + Math.Abs(this.Y - target.Y);
        }

        public void Move(Movement move) // changes the movement of a character
        {
            switch (move)
            {
                case Movement.Up:
                    Y += 1;
                    break;
                case Movement.Down:
                    Y -= 1;
                    break;
                case Movement.Left:
                    X -= 1;
                    break;
                case Movement.Right:
                    X += 1;
                    break;
                case Movement.noMovement:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0); // returns the direction 
        public abstract override string ToString();

    }
}


