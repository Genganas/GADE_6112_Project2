using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    public abstract class Tile
    {
        protected int x;
        protected int y;

        public Tile(int x, int y) //Public accessor method
        {
            this.x = x;
            this.y = y;
        }
        //Tiletype enum for the types of tiles
        public enum Tiletype
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            EmptyTile,
            Obstacle
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Tiletype Type { get; set; }
    }
}


