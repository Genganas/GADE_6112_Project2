using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Gold:Item
    {
        
        protected Random random = new Random();
        public int GetGold(int goldAmount)
        {
            Random rnd = new Random();
            goldAmount = rnd.Next(5);
             return goldAmount;
        }
        
        public Gold(int x, int y) : base(x, y)
        {
        }
    }
}
