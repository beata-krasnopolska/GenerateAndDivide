using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrateAndDivide
{
    class RandomFinder
    {
        Random rnd = new Random();
        public int GetPseudoRandom()
        {
            return rnd.Next(200, 400);
        }
    }
}
