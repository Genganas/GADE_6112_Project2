using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    abstract class Item : Tile
    {
        public Item(int x, int y) : base(x, y)
        {
        }
        public abstract override string ToString();
     

    }
}
