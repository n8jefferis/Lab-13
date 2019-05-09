using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Player
    {
        //props
        public string Name { get; set; }
        public string RPSValue { get; set; }

        //constructors
        public Player(string name)
        {
            this.Name = Name;
        }

        public abstract string GenerateRoshambo(); 

    }
}
