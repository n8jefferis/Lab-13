using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Rocky : Player
    {
        //constructor
        public Rocky(string Name) : base(Name)
        {

        }
        //methods
        public override string GenerateRoshambo()
        {
            return RPS.Rock;
        }
    }
}
