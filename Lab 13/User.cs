using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class User : Player
    {
        

        public User (string Name) : base(Name)
        {
            
        }

        
        
        public override string GenerateRoshambo()
        {
            

            Validator.ValidateInput("What would you like to do? (Rock, Paper, or Scissors)");
            
        }
    }
}
